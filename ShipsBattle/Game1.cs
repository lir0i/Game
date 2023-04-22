using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ShipsBattle.Content;

namespace ShipsBattle
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D texture;
        Vector2 position = new Vector2(10, 10);
        float speed = 2f;
        Entity Player = new Entity();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>("pirat_ship");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.W))
                Player.MoveTo(Direction.Forward);

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                Player.MoveTo(Direction.Left);

            if (Keyboard.GetState().IsKeyDown(Keys.S))
                Player.MoveTo(Direction.Backward);

            if (Keyboard.GetState().IsKeyDown(Keys.D))
                Player.MoveTo(Direction.Right);


            position.X += speed;
            if (position.X > Window.ClientBounds.Width - texture.Width || position.X < 0)
                speed *= -1.01f;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(texture, position,new Rectangle(100, 0, 120, 200), Color.White);

            _spriteBatch.Draw(texture, Player.Position(), new Rectangle(300, 0, 120, 200), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}