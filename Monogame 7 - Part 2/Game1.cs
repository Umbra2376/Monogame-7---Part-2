using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_7___Part_2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D shipTexture;
        Rectangle shipRect;
        float shipAngle;
        Vector2 shipPosition;
        Vector2 shipDirection;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            shipAngle = 0;
            shipPosition = new Vector2(100, 100);
            shipRect = new Rectangle(shipPosition.ToPoint(), new Point(50, 50));
            shipDirection = Vector2.Zero;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            shipTexture = Content.Load<Texture2D>("enterprise");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(shipTexture, shipRect, Color.White);
            _spriteBatch.Draw(shipTexture, shipRect, null, Color.White, 1f, new Vector2(shipRect.Width / 2, shipRect.Height / 2), SpriteEffects.None, 1f);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
