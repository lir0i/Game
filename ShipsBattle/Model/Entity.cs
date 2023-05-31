using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle
{
    public class Entity : Sprite
    {
        public float Speed;

        public bool IsRemoved = false;
        

        public float RotationVelocity;
        public float LinerVelocity;
        public Rectangle? SourceRectangle = null;
        public float Scale = 1;


        public Entity(string name, Vector2 position, int hitBoxHeight, int hitBoxWidth, Vector2 direction) : base(name, position, hitBoxHeight, hitBoxWidth, direction)
        {
        }
    }
}