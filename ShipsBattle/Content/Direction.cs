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
        public static Vector2 Left => new Vector2(-1, 0);
        public static Vector2 Right => new Vector2(1, 0);
        public static Vector2 Forward => new Vector2(0, -1);
        public static Vector2 Backward => new Vector2(0, 1); 
    }
}
