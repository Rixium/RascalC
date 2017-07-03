using Rascal.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rascal.GameClasses.Map {

    class MapLoader {

        public MapLoader() {

        }

        internal static Dictionary<string, int[,]> LoadMap(int levelID) {
            Dictionary<string, int[,]> dictionary = new Dictionary<string, int[,]>();

            XmlDocument doc = new XmlDocument();
            doc.Load(String.Format("Content/Maps/{0}.tmx", levelID));
            XmlNodeList layers = doc.DocumentElement.SelectNodes("layer");

            foreach(XmlNode layer in layers) {
                XmlAttributeCollection nodeAttributes = layer.Attributes;
                string layerName = nodeAttributes.GetNamedItem("name").Value;
                int width = int.Parse(nodeAttributes.GetNamedItem("width").Value);
                int height = int.Parse(nodeAttributes.GetNamedItem("height").Value);
                XmlNodeList tiles = layer.SelectSingleNode("data").SelectNodes("tile");
                int[,] tileMap = new int[width, height];
                for(int i = 0; i < width; i++) {
                    for(int j = 0; j < height; j++) {
                        tileMap[i, j] = int.Parse(tiles[j * Application.MAP_SIZE + i].Attributes["gid"].Value) - 1;
                    }
                }
                dictionary.Add(layerName, tileMap);
            }

            return dictionary;
        }

    }
}
