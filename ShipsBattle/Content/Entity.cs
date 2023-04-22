using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle.Content
{
    public struct Entity
    {
        public static int x;
        public static int y;

        public Entity() 
        { 
            x = 0;
            y = 0;
        }
        public void MoveTo(Point directoin)
        {
            x += directoin.X;
            y += directoin.Y;
        }
        public Vector2 Position()
        {
            return new Vector2(x, y);
        }
    }
}
