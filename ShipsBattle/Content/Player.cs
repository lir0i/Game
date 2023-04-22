using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle.Content
{
    public class Player : IEntity
    {
        private static int x;
        private static int y;

        public static int Y { get => y; set => y = value; }
        public static int X { get => x; set => x = value; }
        public static Texture2D Sprite { get => sprite; set => sprite = value; }

        public static double speed;
        public static double rotationSpeed;

        private static Texture2D sprite;

        public Player()
        {
            X = 0;
            Y = 0;
        }

        public Player(int x, int y, Texture2D sprite)
        {
            X = x;
            Y = y;
            Sprite = sprite;
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
