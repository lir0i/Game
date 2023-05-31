using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ShipsBattle
{
    public class Sprite
    { 
        public string Name { get; private set; }
        public Vector2 Position { get; private set; }
        public Vector2 Origin { get; }
        public int HitBoxHeight { get; }
        public int HitBoxWidth { get; }
        public float Rotation { get; set; }
        public Vector2 Direction { get; set; }
        public Color Color { get; set; }

        public Sprite(string name, Vector2 position, int hitBoxHeight, int hitBoxWidth, Vector2 direction)
        {
            Name = name;
            Position = position;
            Origin = new Vector2(hitBoxWidth / 2f, hitBoxHeight / 2f);
            HitBoxHeight = hitBoxHeight;
            HitBoxWidth = hitBoxWidth;
            Direction = direction;
            Color = Color.White;
        }

        public void Move(Vector2 offset)
        {
            Position += offset;
        }

        public void Rotate(float offset)
        {
            Rotation += offset;
        }

        public Rectangle Rectangle => new((int)(Position.X - Origin.X), (int)(Position.Y - Origin.Y), HitBoxWidth, HitBoxHeight);
    }
}
