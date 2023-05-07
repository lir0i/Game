using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ShipsBattle.Content
{
    public class Splash : IEntity
    {
        private static float x;
        private static float y;

        public static float Y { get => y; set => y = value; }
        public static float X { get => x; set => x = value; }
        public static Texture2D Sprite { get => sprite; set => sprite = value; }

        public static float speed = 5;
        public Vector2 Positin;
        public Vector2 Origin;
        public Vector2 Direction;


        public float rotationSpeed;
        public float RotationVelocity = 3f;
        public float LineryVelocity = 4f;

        private static Texture2D sprite;

        public Splash()
        {
            X = 0;
            Y = 0;
        }

        public Splash(float x, float y, Texture2D sprite, Vector2 direction)
        {
            Positin = new Vector2(x, y);
            Sprite = sprite;
            rotationSpeed = 0;
            Direction = direction;
        }

        public void MoveTo(Vector2 directoin)
        {
            Positin.X += directoin.X;
            Positin.Y += directoin.Y;
        }

        public  bool Hidden 
        {
            get 
            {
                return Positin.X > GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width 
                    || Positin.Y > GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            } 
        }

        public void Update()
        {
            if(!Hidden)
                MoveTo(Direction * speed);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, Positin, null, Color.White, rotationSpeed, Origin, 1, SpriteEffects.None, 0f);
        }
    }
}
