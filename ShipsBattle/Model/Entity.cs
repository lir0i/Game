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
    public class Entity
    {
        public string Name;
        public Vector2 Position;
        public Color Color = Color.White;
        public float Speed;
        public Vector2 Direction;

        public bool IsRemoved = false;

        public Vector2 Origin;
        public float Rotation;
        public float RotationVelocity;
        public float LinerVelocity;
        public Rectangle? SourceRectangle = null;
        public float Scale = 1;

        //public SpriteEffects SpriteEffects = SpriteEffects.None;
        //public float LayerDepth = 0;

        public virtual void Update(GameTime gameTime)
        {
            return;
        }

        public void UpdateViewData()
        {
            //Drawer.Data[Name] = new ViewData(
            //    GetType(),
            //    Name,
            //    Position,
            //    Color,
            //    Origin,
            //    IsRemoved,
            //    Speed,
            //    Rotation,
            //    SourceRectangle,
            //    Scale//,
            //    //SpriteEffects,
            //    //LayerDepth
            //);

            Drawer.Data.Add(new ViewData(
                GetType(),
                Name,
                Position,
                Color,
                Origin,
                IsRemoved,
                Speed,
                Rotation,
                SourceRectangle,
                Scale //,
                //SpriteEffects,
                //LayerDepth
            ));
        }
    }
}