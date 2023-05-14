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
        public Bullet Bullet;
        public Input Input;
        public bool IsDied = false;

        public Player(string name)
        {
            Name = name;
        }

        public void Shoot()
        {
            var bullet = Bullet.Clone() as Bullet;
            bullet.Direction = Direction;
            bullet.Position = Position;
            bullet.LinerVelocity = LinerVelocity * 2;
            bullet.LifeSpan = 2;
            bullet.Parent = this;
            bullet.Origin = new Vector2(10, 65);
            bullet.Rotation = Rotation;
            Global.AddEntity(bullet);
        }

        public void Move(Vector2 offset)
        {
            Position += offset;
        }

        public void Rotate(float offset)
        {
            Rotation += offset;
        }
    }
}
