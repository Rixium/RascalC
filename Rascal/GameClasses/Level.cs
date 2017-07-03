using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rascal.GameClasses.Map;

namespace Rascal.GameClasses {

    class Level {

        private TiledMap map;

        public Level(int levelID) {
            map = new TiledMap(1);
        }

        public void Update(GameTime gameTime) {
            map.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch) {
            map.Draw(spriteBatch);
        }

    }

}
