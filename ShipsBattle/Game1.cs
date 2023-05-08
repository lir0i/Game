using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace ShipsBattle
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        public Drawer Drawer;
        public Controller Controller;


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
            Drawer = new Drawer();
            Controller = new Controller();
            Global.Content = Content;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Drawer.LoadTexture();
        }

        protected override void Update(GameTime gameTime)
        {
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Controller.Update();



            
            //Player1.Update();

            //foreach (var splash in splashes)
            //    splash.Update();


            //if (Keyboard.GetState().IsKeyDown(Keys.I))
            //    Player2.MoveTo(Direction.Forward);

            //if (Keyboard.GetState().IsKeyDown(Keys.J))
            //    Player2.MoveTo(Direction.Left);

            //if (Keyboard.GetState().IsKeyDown(Keys.K))
            //    Player2.MoveTo(Direction.Backward);

            //if (Keyboard.GetState().IsKeyDown(Keys.L))
            //    Player2.MoveTo(Direction.Right);


            //if (Keyboard.GetState().IsKeyDown(Keys.U))
            //    Player2.Rotate(-1);
            //if (Keyboard.GetState().IsKeyDown(Keys.O))
            //    Player2.Rotate(1);


            //if (Collide())
            //    Rock.ChangeColor(Color.Red);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            
            Drawer.Draw(_spriteBatch);



            //if(splashes != null)
            //{
            //    foreach (var splash in splashes)
            //        splash.Draw(_spriteBatch);
            //}
            
            
            //_spriteBatch.Draw(_background, new Vector2(0, 0), Color.White);

            //Player1.Draw(_spriteBatch);


            //_spriteBatch.Draw(texture,
            //                  Player2.Position(),
            //                  null,
            //                  Color.White);


            //Rock.Draw(_spriteBatch);

            //foreach(var splash in splashes)
            //    splash.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        //public static void ShipsFire(Vector2 position, Vector2 direction)
        //{
        //    splashes.Add(new Splash(position.X, position.Y, _splash, direction));
        //}

        //protected bool Collide()
        //{
        //    Rectangle firstSprite = new Rectangle((int)Rock.Position().X,
        //        (int)Rock.Position().Y, rock.Width, rock.Height);
        //    Rectangle secondSprite = new Rectangle((int)Player1.X,
        //        (int)Player1.Y, texture.Width, texture.Height);

        //    return secondSprite.Intersects(firstSprite);
        //}
    }
}