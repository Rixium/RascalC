using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rascal.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascal.GameClasses.Map {

    class TiledMap {

        private int[,] wallTiles;
        private int[,] floorTiles;
        private int[,] objects;
        private int[,] doorTiles;

        public TiledMap(int mapID) {
            Dictionary<string, int[,]> tiles = MapLoader.LoadMap(mapID);
            wallTiles = tiles["Walls"];
            floorTiles = tiles["Floors"];
            doorTiles = tiles["Doors"];
        }

        public void Update(GameTime gameTime) {

        }

        public void Draw(SpriteBatch spriteBatch) {
            for(int i = 0; i < wallTiles.GetLength(0); i++) {
                for(int j = 0; j < wallTiles.GetLength(1); j++) {
                    if(wallTiles[i, j] != -1 && wallTiles[i, j] != 0) {
                        spriteBatch.Draw(ContentChest.Instance.wallTiles, new Rectangle(i * Application.TILE_SIZE, j * Application.TILE_SIZE, Application.TILE_SIZE, Application.TILE_SIZE),
                            ContentChest.Instance.wallRectangles[wallTiles[i, j]], Color.White);
                    }
                }
            }
            for(int i = 0; i < floorTiles.GetLength(0); i++) {
                for(int j = 0; j < floorTiles.GetLength(1); j++) {
                    if(floorTiles[i, j] != -1 && floorTiles[i, j] != 0) {
                        spriteBatch.Draw(ContentChest.Instance.floorTiles, new Rectangle(i * Application.TILE_SIZE, j * Application.TILE_SIZE, Application.TILE_SIZE, Application.TILE_SIZE),
                            ContentChest.Instance.floorRectangles[floorTiles[i, j]], Color.White);
                    }
                }
            }
            for(int i = 0; i < doorTiles.GetLength(0); i++) {
                for(int j = 0; j < doorTiles.GetLength(1); j++) {
                    if(doorTiles[i, j] != -1 && doorTiles[i, j] != 0) {
                        spriteBatch.Draw(ContentChest.Instance.doorTiles, new Rectangle(i * Application.TILE_SIZE, j * Application.TILE_SIZE, Application.TILE_SIZE, Application.TILE_SIZE),
                            ContentChest.Instance.doorRectangles[doorTiles[i, j]], Color.White);
                    }
                }
            }
        }
    }

}
