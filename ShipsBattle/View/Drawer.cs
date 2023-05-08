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

        public static void DrawBackground(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(Sprites["Background"], new Vector2(0, 0), Color.White);
        }

        public static void LoadTexture()
        {
            AddToSprites("Player1", "pirat_ship");
            AddToSprites("Player2", "pirat_ship");
            AddToSprites("Splash", "splash");
            AddToSprites("Entity", "rock");
            AddToSprites("Background", "space-stars");
        }

        private static void AddToSprites(string type, string sprite)
        {
            Sprites.Add(type, Global.Content.Load<Texture2D>(sprite));
        }
    }
}
