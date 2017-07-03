using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rascal.Constants;
using Rascal.PlayerClasses;

namespace Rascal.Interface {

    class UserInterface {

        private Player player;
        private SpriteFont font = ContentChest.Instance.menuFont;
        private SpriteFont font2 = ContentChest.Instance.uiFontSmall;
        public UserInterface(Player player) {
            this.player = player;
        }

        public void Update(GameTime gameTime) {

        }

        public void Draw(SpriteBatch spriteBatch) {
            for(int i = 0; i < player.GetStats().health; i++) {
                spriteBatch.Draw(ContentChest.Instance.heart, new Vector2(10 * (i + 1) + ContentChest.Instance.heart.Width * i, 10), Color.White);
            }

            spriteBatch.DrawString(font, player.name, new Vector2(Application.WINDOW_WIDTH - font.MeasureString(player.name).X - 10, 10), Color.White);
            spriteBatch.DrawString(font2, player.title, new Vector2(Application.WINDOW_WIDTH - font2.MeasureString(player.title).X - 10, 30), Color.White);

            spriteBatch.Draw(ContentChest.Instance.coinsUI, new Rectangle(10, Application.WINDOW_HEIGHT - (ContentChest.Instance.coinsUI.Height * 2) - 10, ContentChest.Instance.coinsUI.Width * 2, ContentChest.Instance.coinsUI.Height * 2), Color.White);
        }
    }

}
