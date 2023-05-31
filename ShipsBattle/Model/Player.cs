using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace ShipsBattle
{
    public class Player : Entity
    {
        public Input Input;
        public bool IsDied = false;

        public Player(string name, Vector2 position, int hitBoxHeight, int hitBoxWidth, Vector2 direction, Input input) 
            : base(name, position, hitBoxHeight, hitBoxWidth, direction)
        {
            Input = input;
            Speed = 2f;
            LinerVelocity = 2f;
            RotationVelocity = 2f;
        }

        public void Shoot()
        {
            var newBullet = new Bullet("bullet" + Name, Position, 10, 10, Direction)
            {
                LifeSpan = 2,
                Parent = this,
                LinerVelocity = LinerVelocity * 2,
                Rotation = Rotation
            };

            Global.AddEntity(newBullet);
        }
    }
}