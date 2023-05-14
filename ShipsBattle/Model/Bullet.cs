using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ShipsBattle
{
    public class Bullet : Entity , ICloneable
    {
        public float LifeSpan = 0;

        public float Timer;

        public Bullet(string name)
        {
            Name = name;
        }

        public void Move(Vector2 offset)
        {
            Position += offset;
        }


        public override void Update(GameTime gameTime)
        {
            Timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (Timer > LifeSpan)
                IsRemoved = true;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
