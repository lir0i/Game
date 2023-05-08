using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShipsBattle
{
    public class ViewData
    {
        public readonly string Type;
        public readonly Vector2 Position;
        public readonly Vector2 Origin;
        public readonly Color Color;
        public readonly float Speed;
        public readonly float RotationSpeed;
        public readonly Rectangle? SourceRectangle;
        public readonly float Scale;
        public readonly SpriteEffects SpriteEffects;
        public readonly float LayerDepth;

        //public ViewData(string type, Vector2 position, Vector2 origin, Color color, float speed, float rotationSpeed,Rectangle sourceRectangle)
        //{
        //    Type = type;
        //    Position = position;
        //    Origin = origin;
        //    Color = color;
        //    Speed = speed;
        //    RotationSpeed = rotationSpeed;
        //    SourceRectangle = sourceRectangle;
        //}

        public ViewData(string type, Vector2 position, Color color, Vector2 origin, float speed = 0, float rotationSpeed = 0, Rectangle? sourceRectangle = null, float scale = 0, SpriteEffects spriteEffects = SpriteEffects.None, float layerDepth = 0)
        {
            Type = type;
            Position = position;
            Origin = origin;
            Color = color;
            Speed = speed;
            RotationSpeed = rotationSpeed;
            SourceRectangle = sourceRectangle;
            Scale = scale;
            SpriteEffects = spriteEffects;
            LayerDepth = layerDepth;
        }
    }
}
