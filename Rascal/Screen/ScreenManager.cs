using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rascal.Screen {

    class ScreenManager {

        private ScreenView currentScreen;

        public void SetScreen(ScreenView screenView) {
            this.currentScreen = screenView;
        }

        public void Update(GameTime gameTime) {
            currentScreen.Update(gameTime);
        }
        public void DrawScreen(SpriteBatch spriteBatch) {
            currentScreen.Draw(spriteBatch);
        }
    }
}
