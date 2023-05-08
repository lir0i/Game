using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;


namespace ShipsBattle
{
    public class Drawer
    {
        public static Dictionary<string, Texture2D> Sprites = new();
        public static List<ViewData> Data = new();

        public void Draw(SpriteBatch _spriteBatch)
        {
            foreach (var view in Data)
            {
                _spriteBatch.Draw(
                    Sprites[view.Type], 
                    view.Position ,
                    view.SourceRectangle, 
                    view.Color, 
                    view.RotationSpeed, 
                    view.Origin, 
                    view.Scale, 
                    view.SpriteEffects, 
                    view.LayerDepth);
            }
            Data.Clear();
        }

        private static void DrawBackground(SpriteBatch _spriteBatch)
        {
            
        }

    }
}
