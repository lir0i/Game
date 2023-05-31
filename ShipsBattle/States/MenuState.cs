using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShipsBattle
{
    public class MenuState : State
    {
        private readonly List<Component> _components;

        public MenuState(ShipsBattle game) : base(game)
        {
            var buttonTexture = Global.Content.Load<Texture2D>("Button");
            var buttonFont = Global.Content.Load<SpriteFont>("Fonts/Font");

            var newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 300),
                Text = "New Game"
            };

            newGameButton.Click += NewGameButtonClick;

            var loadGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 400),
                Text = "Load Game"
            };

            loadGameButton.Click += LoadGameButtonClick;

            var quitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 500),
                Text = "Quit"
            };

            quitGameButton.Click += QuitGameButtonClick;

            _components = new List<Component>()
            {
                newGameButton,
                loadGameButton,
                quitGameButton
            };
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
            {
                component.Draw(gameTime, spriteBatch);
            }

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
            {
                component.Update(gameTime);
            }
        }

        public override void PostUpdate(GameTime gameTime)
        {
            //todo
        }
        
        private void NewGameButtonClick(object sender, EventArgs e)
        {
            Game.ChangeState(new LevelSelectionState(Game));
        }
        
        private void LoadGameButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("я пока что не сделяль");
        }

        private void QuitGameButtonClick(object sender, EventArgs e)
        {
            Game.Exit();
        }
    }
}
