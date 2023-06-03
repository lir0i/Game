using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsBattle
{
    public class ViewDataBuilder
    {
        public static void Build(Sprite sprite)
        {
            var type = sprite.GetType();

            if (type == typeof(Sprite))
            {
                BasicAdd(sprite);
                return;
            }

            if (type == typeof(Player))
            {
                var player = (Player)sprite;
                Drawer.AddToData(new ViewData(
                    type,
                    player.Name,
                    player.Position,
                    player.Color, 
                    player.Origin,
                    player.Rotation,
                    player.Health));
                return;
            }

            Drawer.AddToData(new ViewData(
                type,
                sprite.Name,
                sprite.Position,
                sprite.Color,
                sprite.Origin,
                sprite.Rotation));
        }

        private static void BasicAdd(Sprite sprite)
        {
            Drawer.AddToData(new ViewData(sprite.GetType(), sprite.Name, sprite.Position, sprite.Color, sprite.Origin));
        }
    }
}
