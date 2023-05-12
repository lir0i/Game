using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle
{
    public class Directions 
    {
        public static Vector2 Left => new Vector2(-1, 0);
        public static Vector2 Right => new Vector2(1, 0);
        public static Vector2 Up => new Vector2(0, -1);
        public static Vector2 Down => new Vector2(0, 1);

        public static Vector2 CalculateDirection(float rotation)
        {
            return new(
                (float)Math.Cos(MathHelper.ToRadians(90) - rotation),
                -(float)Math.Sin(MathHelper.ToRadians(90) - rotation)
                );
        }
    }
}
