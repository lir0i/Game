using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle.Content
{
    public class Player1 : IEntity
    {
        private static float x;
        private static float y;

        public static float Y { get => y; set => y = value; }
        public static float X { get => x; set => x = value; }
        public static Texture2D Sprite { get => sprite; set => sprite = value; }

        public static float speed;

        public Vector2 Positin;
        public Vector2 Origin;
        public float rotationSpeed;
        public float RotationVelocity = 3f;
        public float LineryVelocity = 4f;

        private static Texture2D sprite;

        public Player1()
        {
            X = 0;
            Y = 0;
        }

        public Player1(float x, float y, Texture2D sprite)
        {
            Positin = new Vector2(x, y);
            Sprite = sprite;
            rotationSpeed = 0;
        }

        public void MoveTo(Vector2 directoin)
        {
            Positin.X += directoin.X;
            Positin.Y += directoin.Y;
        }

        public void Rotate(int Angle) 
        {
            rotationSpeed = Angle;
        }

        public Vector2 GetPosForSplash => new(Positin.X + 30, Positin.Y + 30);             
                 
           

        public void Update() 
        {
            var pressedKey = Keyboard.GetState();
            if (pressedKey.IsKeyDown(Keys.Q))
                rotationSpeed -= MathHelper.ToRadians(RotationVelocity);
            if (pressedKey.IsKeyDown(Keys.E))
                rotationSpeed += MathHelper.ToRadians(RotationVelocity);

            var direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotationSpeed), -(float)Math.Sin(MathHelper.ToRadians(90) - rotationSpeed));

            if (pressedKey.IsKeyDown(Keys.W))
            {
                Positin += direction * LineryVelocity;
            }

            if (pressedKey.IsKeyDown(Keys.S))
            {
                Positin -= direction * LineryVelocity;
            }


            if (pressedKey.IsKeyDown(Keys.A))
            {
                Positin += new Vector2(direction.Y, -direction.X) * LineryVelocity;
            }
            if (pressedKey.IsKeyDown(Keys.D))
            {
                Positin -= new Vector2(direction.Y, -direction.X) * LineryVelocity;
            }

            if (pressedKey.IsKeyDown(Keys.LeftShift))
            {
                Game1.ShipsFire(Positin, direction);
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, Positin, null, Color.White, rotationSpeed, Origin, 1, SpriteEffects.None, 0f);
        }
    }






    public class Player2 : IEntity
    {
        private static float x;
        private static float y;

        public static float Y { get => y; set => y = value; }
        public static float X { get => x; set => x = value; }
        public static Texture2D Sprite { get => sprite; set => sprite = value; }

        public static float speed;
        public static float rotationSpeed;

        private static Texture2D sprite;

        public Player2()
        {
            X = 0;
            Y = 0;
        }

        public Player2(float x, float y, Texture2D sprite)
        {
            X = x;
            Y = y;
            Sprite = sprite;
            rotationSpeed = 0;
        }

        public void MoveTo(Vector2 directoin)
        {
            X += directoin.X;
            Y += directoin.Y;
        }

        public Vector2 Position()
        {
            return new Vector2(X, Y);
        }

        public bool isRotaiting()
        {
            return rotationSpeed != 0;
        }

        public void Rotate(int Angle)
        {
            rotationSpeed = Angle;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
