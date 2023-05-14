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

        public static Player Player1;
        public static Player Player2;

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

            InitializePlayers();

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

            Controller.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            
            Drawer.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }



        private void InitializePlayers()
        {
            
            Player1 = new Player("Player1")
            {
                Bullet = new Bullet("Bullet"),
                Position = new(100, 100),
                Speed = 5,
                Origin = new Vector2(110, 120),
                LinerVelocity = 4,
                RotationVelocity = 3,
                Rotation = 0,
                Scale = 0.2f,
                Input = new Input()
                {
                    Down = Keys.S,
                    Up = Keys.W,
                    Left = Keys.A,
                    Right = Keys.D, 
                    RotateLeft = Keys.Q,
                    RotateRight = Keys.E,
                    Shoot = Keys.LeftShift
                }
            };
            Player2 = new Player("Player2")
            {
                Bullet = new Bullet("Bullet"),
                Position = new(200, 100),
                Speed = 5,
                Origin = new Vector2(110, 120),
                LinerVelocity = 4,
                RotationVelocity = 3,
                Rotation = 0,
                Scale = 0.2f,
                Input = new Input()
                {
                    Down = Keys.K,
                    Up = Keys.I,
                    Left = Keys.J,
                    Right = Keys.L,
                    RotateLeft = Keys.U,
                    RotateRight = Keys.O,
                    Shoot = Keys.RightShift
                }
            };
            Global.Entities.Add(Player1);
            Global.Entities.Add(Player2);
            Player1.UpdateViewData();
            Player2.UpdateViewData();
        }
    }
}