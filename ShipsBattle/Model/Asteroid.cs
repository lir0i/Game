using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ShipsBattle
{
    public class Asteroid : Entity
    {
        public bool IsDestructible { get; }
        public float RotationSpeed { get; }

        public Asteroid(string name, Vector2 position, int hitBoxHeight, int hitBoxWidth, Vector2 direction, float rotationSpeed,float speed, bool isDestructible = false) 
            : base(name, position, hitBoxHeight, hitBoxWidth, direction)
        {
            Speed = speed;
            RotationSpeed = rotationSpeed;
            IsDestructible = isDestructible;
        }
    }
}
