using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle.Content
{
    public class Direction 
    {
        public static Point Left => new Point(-1, 0);
        public static Point Right => new Point(1, 0);
        public static Point Forward => new Point(0, -1);
        public static Point Backward => new Point(0, 1); 
    }
}
