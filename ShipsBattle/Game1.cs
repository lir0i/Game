using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ShipsBattle.Content;
using System.Collections.Generic;

namespace ShipsBattle
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D texture;
        Texture2D shipsParts;
        Vector2 position;
        float speed;
        Player1 Player1;
        Player2 Player2;
        Texture2D _background;
        Texture2D rock;
        Entity Rock;
        public static Texture2D _splash;

        public static List<Splash> splashes = new();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            speed = 2f;
            position = new Vector2(50, 50);
            
            Player2 = new Player2(position.X, position.Y, texture);
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>("pirat_ship");
            _splash = Content.Load<Texture2D>("splash");
            shipsParts = Content.Load<Texture2D>("shipsheetparts");
            rock = Content.Load<Texture2D>("rock");

            Player1 = new Player1(position.X, position.Y, texture)
            {
                Origin = new Vector2(texture.Width / 2, texture.Height / 2)
            };
            Rock = new Entity(rock);


            _background = Content.Load<Texture2D>("space-stars");
            
        }

        protected override void Update(GameTime gameTime)
        {
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Player1.Update();

            foreach (var splash in splashes)
                splash.Update();


            if (Keyboard.GetState().IsKeyDown(Keys.I))
                Player2.MoveTo(Direction.Forward);

            if (Keyboard.GetState().IsKeyDown(Keys.J))
                Player2.MoveTo(Direction.Left);

            if (Keyboard.GetState().IsKeyDown(Keys.K))
                Player2.MoveTo(Direction.Backward);

            if (Keyboard.GetState().IsKeyDown(Keys.L))
                Player2.MoveTo(Direction.Right);


            if (Keyboard.GetState().IsKeyDown(Keys.U))
                Player2.Rotate(-1);
            if (Keyboard.GetState().IsKeyDown(Keys.O))
                Player2.Rotate(1);


            if (Collide())
                Rock.ChangeColor(Color.Red);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            
            
            if(splashes != null)
            {
                foreach (var splash in splashes)
                    splash.Draw(_spriteBatch);
            }
            
            
            _spriteBatch.Draw(_background, new Vector2(0, 0), Color.White);

            Player1.Draw(_spriteBatch);


            _spriteBatch.Draw(texture,
                              Player2.Position(),
                              null,
                              Color.White);


            Rock.Draw(_spriteBatch);

            foreach(var splash in splashes)
                splash.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        static public void ShipsFire(Vector2 position, Vector2 direction)
        {
            splashes.Add(new Splash(position.X, position.Y, _splash, direction));
        }

        protected bool Collide()
        {
            Rectangle firstSprite = new Rectangle((int)Rock.Position().X,
                (int)Rock.Position().Y, rock.Width, rock.Height);
            Rectangle secondSprite = new Rectangle((int)Player1.X,
                (int)Player1.Y, texture.Width, texture.Height);

            return secondSprite.Intersects(firstSprite);
        }
    }
}