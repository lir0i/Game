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
    public class Bullet : Entity
    {
        public float LifeSpan = 0;
        public Entity Parent;
        public float Timer;

        public Bullet(string name, Vector2 position, int hitBoxHeight, int hitBoxWidth, Vector2 direction) : base(name, position, hitBoxHeight, hitBoxWidth, direction)
        {
        }





        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
    }
}
