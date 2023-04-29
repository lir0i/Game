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
        public void MoveTo(Point directoin);
        //public Vector2 Position();
        //public void Draw(SpriteBatch spriteBatch);
    }

    
    public class Entity : IEntity
    {
        private Texture2D _texture;

        private static int x;
        private static int y;

        public static int Y { get => y; set => y = value; }
        public static int X { get => x; set => x = value; }

        public Entity() 
        { 
            X = 50;
            Y = 50;
        }
        public void MoveTo(Point directoin)
        {
            X += directoin.X;
            Y += directoin.Y;
        }
        public Vector2 Position()
        {
            return new Vector2(X, Y);
        }
    }
}
