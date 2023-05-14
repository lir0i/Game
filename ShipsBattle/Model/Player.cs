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
        
        public Player(string name)
        {
            Name = name;
        }

        public void Shoot()
        {
            var bullet = Bullet.Clone() as Bullet;
            bullet.Direction = this.Direction;
            bullet.Position = this.Position;
            bullet.LinerVelocity = this.LinerVelocity * 2;
            bullet.LifeSpan = 2;
            bullet.Parent = this;
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
