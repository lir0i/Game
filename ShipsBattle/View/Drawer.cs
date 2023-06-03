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
        private static readonly SpriteFont Font = Global.Content.Load<SpriteFont>("Fonts/Font");
        private static readonly List<ViewData> Data = new();

        public void Draw(SpriteBatch spriteBatch)
        {
            DrawBackground(spriteBatch);

            foreach (var view in Data)
            {
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
                if (view.Type == typeof(Player))
                {
                    spriteBatch.DrawString(Font, "Health:" + view.Health, new Vector2(view.Position.X + view.Origin.X, view.Position.Y + view.Origin.Y), Color.White);
                }
            }

            Data.Clear();
        }

        public static void AddToData(ViewData view)
        {
            Data.Add(view);
        }
        private static void DrawBackground(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprites[Global.BackgroundName], new Vector2(0, 0), Color.White);
        }

        public static void LoadTexture()
        {
            AddToSprites("Player", "ship (1)");
            AddToSprites("Bullet", "splash");
            AddToSprites("Asteroid", "rock");
            AddToSprites("Entity", "rock");
            AddToSprites("space", "space");
            AddToSprites("space-stars", "space-stars");
            AddToSprites("state", "state");
            AddToSprites("main_menu", "main_menu");
        }

        private static void AddToSprites(string type, string sprite)
        {
            Sprites.Add(type, Global.Content.Load<Texture2D>(sprite));
        }
    }
}
