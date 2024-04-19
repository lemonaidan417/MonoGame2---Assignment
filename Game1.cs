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
        Rectangle blackTriangle;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();


            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(-7, 448, 360, 360), Color.Goldenrod);
                _spriteBatch.Draw(triangleTexture, new Rectangle(167, 110, 360, 360), Color.Goldenrod);
                _spriteBatch.Draw(triangleTexture, new Rectangle(341, 448, 360, 360), Color.Goldenrod);
            } // Big Triforce

            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(169, 286, 180, 180), Color.Black);
                _spriteBatch.Draw(triangleTexture, new Rectangle(257, 116, 180, 180), Color.Black);
                _spriteBatch.Draw(triangleTexture, new Rectangle(343, 286, 180, 180), Color.Black);
            } // Mini Triforce (Middle)
            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(169, 448, 180, 180), Color.Red);
                _spriteBatch.Draw(triangleTexture, new Rectangle(257, 110, 180, 180), Color.Green);
                _spriteBatch.Draw(triangleTexture, new Rectangle(343, 448, 180, 180), Color.Blue);
            } // Mini Triforce (Left)
            {
                _spriteBatch.Draw(triangleTexture, new Rectangle(-7, 630, 180, 180), Color.Pink);
                _spriteBatch.Draw(triangleTexture, new Rectangle(165, 630, 180, 180), Color.Purple);
                _spriteBatch.Draw(triangleTexture, new Rectangle(343, 448, 180, 180), Color.Magenta);
            } // Mini Triforce (Right)



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}