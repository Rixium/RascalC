using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rascal.GameClasses;
using Microsoft.Xna.Framework.Input;

namespace Rascal.Screen {

    class GameScreen : ScreenView {

        protected GameInstance game;

        public GameScreen(ScreenManager manager) {
            this.manager = manager;
            game = new GameInstance();
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            KeyboardState ks = Keyboard.GetState();
            if(ks.IsKeyDown(Keys.Escape)) {
                manager.SetScreen(new MenuScreen(manager));
            }
            game.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch) {
            base.Draw(spriteBatch);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);
            game.Draw(spriteBatch);
            spriteBatch.End();
        }
    }

}
