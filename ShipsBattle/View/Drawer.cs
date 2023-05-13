using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ShipsBattle
{
    public class Drawer
    {
        public static readonly Dictionary<string, Texture2D> Sprites = new();

        public static List<ViewData> Data = new();

        public void Draw(SpriteBatch spriteBatch)
        {
            DrawBackground(spriteBatch);

            foreach (var view in Data)
            {
                if (view.IsRemoved)
                    continue;
                spriteBatch.Draw(
                    Sprites[view.Type.Name], 
                    view.Position ,
                    view.SourceRectangle, 
                    view.Color, 
                    view.Rotation, 
                    view.Origin, 
                    view.Scale, 
                    view.SpriteEffects, 
                    view.LayerDepth);
            }

            Data.Clear();
        }

        private static void DrawBackground(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprites["Background"], new Vector2(0, 0), Color.White);
        }

        public static void LoadTexture()
        {
            AddToSprites("Player", "ship (1)");
            AddToSprites("Bullet", "splash");
            AddToSprites("Entity", "rock");
            AddToSprites("Background", "space-stars");
        }

        private static void AddToSprites(string type, string sprite)
        {
            Sprites.Add(type, Global.Content.Load<Texture2D>(sprite));
        }
    }
}
