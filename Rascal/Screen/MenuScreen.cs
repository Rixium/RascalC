using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rascal.Constants;
using Microsoft.Xna.Framework.Input;
using Rascal.Config;

namespace Rascal.Screen {

    class MenuScreen : ScreenView {

        private int selectedItem = 0;
        private KeyboardState lastKeyState;

        public MenuScreen(ScreenManager manager) {
            this.manager = manager;
        }
        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Begin();
            switch(selectedItem) {
                case 0:
                    spriteBatch.DrawString(ContentChest.Instance.menuFont, "Start <", new Vector2(10, 10), Color.White);
                    spriteBatch.DrawString(ContentChest.Instance.menuFont, "Exit", new Vector2(10, 30), Color.White);
                    break;
                case 1:
                    spriteBatch.DrawString(ContentChest.Instance.menuFont, "Start", new Vector2(10, 10), Color.White);
                    spriteBatch.DrawString(ContentChest.Instance.menuFont, "Exit <", new Vector2(10, 30), Color.White);
                    break;
                default:
                    break;
            }

            spriteBatch.DrawString(ContentChest.Instance.menuFont, "UP: " + KeyBindings.UP.ToString(), new Vector2(10, 80), Color.White);
            spriteBatch.DrawString(ContentChest.Instance.menuFont, "DOWN: " + KeyBindings.DOWN.ToString(), new Vector2(10, 100), Color.White);
            spriteBatch.DrawString(ContentChest.Instance.menuFont, "LEFT: " + KeyBindings.LEFT.ToString(), new Vector2(10, 120), Color.White);
            spriteBatch.DrawString(ContentChest.Instance.menuFont, "RIGHT: " + KeyBindings.RIGHT.ToString(), new Vector2(10, 140), Color.White);
            spriteBatch.DrawString(ContentChest.Instance.menuFont, "SELECT: " + KeyBindings.SELECT.ToString(), new Vector2(10, 160), Color.White);

            spriteBatch.DrawString(ContentChest.Instance.menuFont, "Rascal", new Vector2(Application.WINDOW_WIDTH - ContentChest.Instance.menuFont.MeasureString("Rascal").X - 10, 
                Application.WINDOW_HEIGHT - ContentChest.Instance.menuFont.MeasureString("Rascal").Y - 10), Color.White);
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime) {
            KeyboardState ks = Keyboard.GetState();

            if(ks.IsKeyDown(KeyBindings.DOWN) && lastKeyState.IsKeyUp(KeyBindings.DOWN)) {
                selectedItem = 1;
            } else if (ks.IsKeyDown(KeyBindings.UP) && lastKeyState.IsKeyUp(KeyBindings.UP)) {
                selectedItem = 0;
            }

            if(ks.IsKeyDown(KeyBindings.SELECT) && lastKeyState.IsKeyUp(KeyBindings.SELECT)) {
                manager.SetScreen(new GameScreen(manager));
            }

            lastKeyState = ks;
        }

    }

}
