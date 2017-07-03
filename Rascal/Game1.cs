using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rascal.Constants;
using Rascal.Screen;

namespace Rascal
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ContentChest contentChest = ContentChest.Instance;
        ScreenManager screenManager;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            ContentChest.Instance.content = this.Content;
            graphics.PreferredBackBufferWidth = Application.WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = Application.WINDOW_HEIGHT;
            graphics.ApplyChanges();
            screenManager = new ScreenManager();
            screenManager.SetScreen(new MenuScreen(screenManager));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            contentChest.LoadContent();
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            screenManager.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            screenManager.DrawScreen(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
