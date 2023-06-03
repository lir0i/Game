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
        public int Health = 10;
        public Input Input;
        public bool IsDied = false;
        private readonly float _bulletLifeSpan;
        private readonly float _bulletLinerVelocity;

        public Player(string name, Vector2 position, int hitBoxHeight, int hitBoxWidth, Vector2 direction, Input input, float bulletLifeSpan, float bulletLinerVelocity, Color color) 
            : base(name, position, hitBoxHeight, hitBoxWidth, direction)
        {
            Color = color;
            Input = input;
            _bulletLifeSpan = bulletLifeSpan;
            _bulletLinerVelocity = bulletLinerVelocity;
            Speed = 2f;
            LinerVelocity = 4f;
            RotationVelocity = 2f;
        }

        public void Shoot()
        {
            var newBullet = new Bullet("bullet" + Name, Position, Drawer.Sprites["Bullet"].Height, Drawer.Sprites["Bullet"].Width, Direction)
            {
                LifeSpan = _bulletLifeSpan,
                Parent = this,
                LinerVelocity = _bulletLinerVelocity,
                Rotation = Rotation
            };
            newBullet.RewriteOrigin(new Vector2(Drawer.Sprites["Bullet"].Height - this.Origin.X + 9, Drawer.Sprites["Bullet"].Width + this.Origin.Y + 15));
            Global.AddSprite(newBullet);
        }
    }
}