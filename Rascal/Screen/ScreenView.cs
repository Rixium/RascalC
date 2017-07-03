using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Rascal.Screen {

    class ScreenView {

        public ScreenManager manager { get; internal set; }

        public virtual void Draw(SpriteBatch spriteBatch) { }

        public virtual void Update(GameTime gameTime) { }

    }
}
