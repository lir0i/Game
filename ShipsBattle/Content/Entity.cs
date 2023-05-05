using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle.Content
{
    public interface IEntity
    {
        public void MoveTo(Vector2 directoin);
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
        //public Vector2 Position();
        //public void Draw(SpriteBatch spriteBatch);
    }

    
    public class Entity : IEntity
    {
        private Texture2D _texture;

        private static float x;
        private static float y;

        public static float Y { get => y; set => y = value; }
        public static float X { get => x; set => x = value; }

        public Entity() 
        { 
            X = 50;
            Y = 50;
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
