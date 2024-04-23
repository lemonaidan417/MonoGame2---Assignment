using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame2___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D triangleTexture;

        Rectangle yellowTriangle;
        Rectangle purpleTriangle;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 697; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 800; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            triangleTexture = Content.Load<Texture2D>("triangle");
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
            GraphicsDevice.Clear(Color.LightSlateGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();


            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(-7, 448, 360, 360), Color.Goldenrod);
                _spriteBatch.Draw(triangleTexture, new Rectangle(167, 110, 360, 360), Color.Goldenrod);
                _spriteBatch.Draw(triangleTexture, new Rectangle(341, 448, 360, 360), Color.Goldenrod);
            } // Big Triforce

            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(169, 286, 180, 180), Color.DarkMagenta);
                _spriteBatch.Draw(triangleTexture, new Rectangle(257, 116, 180, 180), Color.DarkMagenta);
                _spriteBatch.Draw(triangleTexture, new Rectangle(343, 286, 180, 180), Color.DarkMagenta);
            } // Mini Triforce (Middle)
            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(431, 455, 180, 180), Color.DarkMagenta);
                _spriteBatch.Draw(triangleTexture, new Rectangle(518, 624, 180, 180), Color.DarkMagenta);
                _spriteBatch.Draw(triangleTexture, new Rectangle(344, 624, 180, 180), Color.DarkMagenta);
            } // Mini Triforce (Left)
            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(-4, 624, 180, 180), Color.DarkMagenta);
                _spriteBatch.Draw(triangleTexture, new Rectangle(170, 624, 180, 180), Color.DarkMagenta);
                _spriteBatch.Draw(triangleTexture, new Rectangle(83, 455, 180, 180), Color.DarkMagenta);
            } // Mini Triforce (Right)



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}