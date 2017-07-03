using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Rascal.Constants;
using System;

namespace Rascal {
    class ContentChest {

        static ContentChest instance;
        public ContentManager content { get; set; }

        public SpriteFont menuFont, uiFontSmall;

        public Texture2D heart;
        public Texture2D coinsUI;
        public Texture2D wallTiles, floorTiles, doorTiles;
        public Rectangle[] wallRectangles, floorRectangles, doorRectangles;

        public static ContentChest Instance {
            get {
                if(instance == null) {
                    instance = new ContentChest();
                }
                return instance;
            }
        }

        public void LoadContent() {
            menuFont = content.Load<SpriteFont>("Fonts/menuFont");
            uiFontSmall = content.Load<SpriteFont>("Fonts/uiFontSmall");
            wallTiles = content.Load<Texture2D>("Tilesets/Wall");
            floorTiles = content.Load<Texture2D>("Tilesets/Floor");
            doorTiles = content.Load<Texture2D>("Tilesets/Door0");

            wallRectangles = LoadRectangles(wallTiles);
            Console.WriteLine(wallRectangles.Length);
            floorRectangles = LoadRectangles(floorTiles);
            doorRectangles = LoadRectangles(doorTiles);

            coinsUI = content.Load<Texture2D>("UI/coinUI");
            heart = content.Load<Texture2D>("UI/heart");
        }

        private Rectangle[] LoadRectangles(Texture2D sheet) {
            // Load tile rectangles.
            int widthInTiles = sheet.Width / 16;
            int heightInTiles = sheet.Height / 16;
            Rectangle[] tempRectangles = new Rectangle[heightInTiles * widthInTiles];
            int num = 0;
            for(int i = 0; i < heightInTiles; i++) {
                for(int j = 0; j < widthInTiles; j++) {
                    tempRectangles[num] = new Rectangle(j * 16, i * 16,
                        16, 16);
                    num++;
                }
            }

            return tempRectangles;
        }


    }
}
