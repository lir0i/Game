using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShipsBattle
{
    public class GameResultState : State
    {
        private readonly List<Component> _components;
        private readonly SpriteFont _font = Global.Content.Load<SpriteFont>("Fonts/Font");
        private readonly string _winnerName;
        public GameResultState(ShipsBattle game, string winnerName) : base(game)
        {
            var buttonTexture = Global.Content.Load<Texture2D>("button3");
            _winnerName = winnerName;
            var quitGameButton = new Button(buttonTexture, _font)
            {
                Position = new Vector2(700, 600),
                Text = "Quit"
            };
            quitGameButton.Click += QuitGameButtonClick;

            _components = new List<Component>()
            {
                quitGameButton
            };
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(Drawer.Sprites["space-stars"], new Vector2(0, 0), Color.White);

            foreach (var component in _components)
            {
                component.Draw(gameTime, spriteBatch);
            }

            spriteBatch.DrawString(_font, _winnerName + " WIN!!!", new Vector2(700, 500), Color.DarkRed, 0, Vector2.Zero, new Vector2(4), SpriteEffects.None, 0);
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

        private void QuitGameButtonClick(object sender, EventArgs e)
        {
            Game.ChangeState(new MenuState(Game));
        }
    }
}
