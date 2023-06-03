using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShipsBattle
{
    public class LevelSelectionState : State
    {
        private readonly List<Component> _components;

        public LevelSelectionState(ShipsBattle game) : base(game)
        {
            var buttonTexture = Global.Content.Load<Texture2D>("button3");
            var buttonFont = Global.Content.Load<SpriteFont>("Fonts/Font");

            var tutorialButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(100, 300),
                Text = "Tutorial"
            };
            tutorialButton.Click += TutorialButtonClick;

            var firstLevelButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(500, 300),
                Text = "1 Level"
            };
            firstLevelButton.Click += FirstLevelButtonClick;

            var secondLevelButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(900, 300),
                Text = "2 Level"
            };
            secondLevelButton.Click += SecondLevelButtonClick;

            var thirdLevelButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(1300, 300),
                Text = "3 Level"
            };
            thirdLevelButton.Click += ThirdLevelButtonClick;

            _components = new List<Component>()
            {
                tutorialButton,
                firstLevelButton,
                secondLevelButton,
                thirdLevelButton
            };
        }

        private void ThirdLevelButtonClick(object sender, EventArgs e)
        {
            LevelManager.LoadThirdLevel();
            LevelManager.UploadLevel();
            Game.ChangeState(new GameState(Game));
        }

        private void SecondLevelButtonClick(object sender, EventArgs e)
        {
            LevelManager.LoadSecondLevel();
            LevelManager.UploadLevel();
            Game.ChangeState(new GameState(Game));
        }

        private void FirstLevelButtonClick(object sender, EventArgs e)
        {
            LevelManager.LoadFirstLevel();
            LevelManager.UploadLevel();
            Game.ChangeState(new GameState(Game));
        }

        private void TutorialButtonClick(object sender, EventArgs e)
        {
            LevelManager.LoadTutorialLevel();
            LevelManager.UploadLevel();
            Game.ChangeState(new GameState(Game));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(Drawer.Sprites["space-stars"], new Vector2(0, 0), Color.White);
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
    }
}