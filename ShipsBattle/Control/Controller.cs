using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace ShipsBattle
{
    public class Controller
    {
        public bool IsFinished;
        public string WinnerName;
        private KeyboardState _previousPressedKey;
        public void Update(GameTime gameTime)
        {
            foreach (var sprite in Global.Sprites)
            {
                switch (sprite.GetType().Name)
                {
                    case "Player":
                    {
                        Update((Player)sprite, gameTime);
                        break;
                    }
                    case "Bullet":
                    {
                        Update((Bullet)sprite, gameTime);
                        break;
                    }
                    case "Asteroid":
                    {
                        Update((Asteroid)sprite, gameTime);
                        break;
                    }
                }

                ViewDataBuilder.Build(sprite);
            }
        }

        public void PostUpdate(GameTime gameTime)
        {
            Global.AddToSprites();
            Global.RemoveFromEntities();
        }


        private void Update(Player player, GameTime gameTime)
        {
            var pressedKey = Keyboard.GetState();
            var input = player.Input;

            if (pressedKey.IsKeyDown(input.RotateLeft))
                player.Rotate(-MathHelper.ToRadians(player.RotationVelocity));

            if (pressedKey.IsKeyDown(input.RotateRight))
                player.Rotate(MathHelper.ToRadians(player.RotationVelocity));

            player.Direction = Directions.CalculateDirection(player.Rotation);

            if (pressedKey.IsKeyDown(input.Up))
                player.Move(player.Direction * player.Speed);

            if (pressedKey.IsKeyDown(input.Down))
                player.Move(-player.Direction * player.Speed);

            if (pressedKey.IsKeyDown(input.Left))
                player.Move(new Vector2(player.Direction.Y, -player.Direction.X) * player.Speed);

            if (pressedKey.IsKeyDown(input.Right))
                player.Move(-new Vector2(player.Direction.Y, -player.Direction.X) * player.Speed);


            if (pressedKey.IsKeyDown(input.Shoot) && _previousPressedKey.IsKeyUp(input.Shoot))
                player.Shoot();

            foreach (var sprite in Global.Sprites)
            {
                if(sprite == player) continue;
                if (sprite.Rectangle.Intersects(player.Rectangle))
                {
                    if (sprite.GetType().Name == "Bullet")
                    {
                        var bullet = sprite as Bullet;
                        if (bullet?.Parent != player)
                        {
                            player.Health--;
                            Global.RemoveSprite(bullet);
                        }
                    }

                    if (sprite.GetType().Name == "Asteroid")
                    {
                        player.Health--;
                    }
                }
            }

            if (player.Health <= 0)
            {
                player.IsDied = true;
                Global.RemoveSprite(player);
                IsFinished = true;
                WinnerName = player.Name == "Player1" ? "Player2" : "Player1";
            }
                

            _previousPressedKey = pressedKey;
        }

        private void Update(Bullet bullet, GameTime gameTime)
        {
            bullet.Timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (bullet.Timer > bullet.LifeSpan)
            {
                Global.RemoveSprite(bullet);
            }

            foreach (var sprite in Global.Sprites)
            {
                if (sprite == bullet) continue;
                if (sprite.Rectangle.Intersects(bullet.Rectangle) && sprite.GetType().Name == "Asteroid")
                {
                    Global.RemoveSprite(bullet);
                }

            }

            bullet.Move(bullet.Direction * bullet.LinerVelocity);
        }
        private void Update(Asteroid asteroid, GameTime gameTime)
        {
            if (asteroid.IsDestructible)
            {
                foreach (var sprite in Global.Sprites)
                {
                    if (sprite == asteroid) continue;
                    if (sprite.Rectangle.Intersects(asteroid.Rectangle) && sprite.GetType().Name == "Bullet")
                    {
                        asteroid.IsRemoved = true;
                    }
                }
            }

            if (asteroid.IsRemoved)
                Global.RemoveSprite(asteroid);
            asteroid.Move(asteroid.Direction * asteroid.Speed);
            asteroid.Rotate(asteroid.RotationSpeed);
        }
    }
}
