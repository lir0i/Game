using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ShipsBattle
{
    public class Global
    {
        public static ContentManager Content;
        public static GraphicsDevice GraphicsDevice;

        public static List<Sprite> Sprites = new();
        public static string BackgroundName;

        private static readonly List<Sprite> ToAdd = new();
        private static readonly List<Sprite> ToRemove = new();

        public static void RemoveFromEntities()
        {
            if (ToRemove.Count == 0)
                return;
            foreach (var sprite in ToRemove)
            {
                Sprites.Remove(sprite);
            }
            ToRemove.Clear();
        }

        public static void AddToSprites()
        {
            if(ToAdd.Count == 0)
                return;
            foreach (var sprite in ToAdd)
            {
                Sprites.Add(sprite);
            }
            ToAdd.Clear();
        }

        public static void AddSprite(Entity sprite)
        {
            ToAdd.Add(sprite);
        }

        public static void RemoveSprite(Entity sprite)
        {
            ToRemove.Add(sprite);
        }

    }
}
