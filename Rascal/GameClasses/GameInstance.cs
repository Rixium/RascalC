using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rascal.Interface;
using Rascal.PlayerClasses;

namespace Rascal.GameClasses {

    class GameInstance {

        Level level;
        Player player;
        UserInterface ui;

        public GameInstance() {
            this.level = new Level(0);
            player = new Player();
            ui = new UserInterface(player);
        }

        public void Update(GameTime gameTime) {
            level.Update(gameTime);
            
        }

        public void Draw(SpriteBatch spriteBatch) {
            level.Draw(spriteBatch);
            ui.Draw(spriteBatch);
        }

    }
}
