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
            switch (type.Name)
            {
                case "Entity":
                {
                    if (sprite is Entity entity)
                        Drawer.Data.Add(new ViewData(type, entity.Name, entity.Position, entity.Color, entity.Origin,
                            entity.IsRemoved, entity.Rotation, null, entity.Scale));
                    break;
                }
                case "Player":
                {
                    if (sprite is Player player)
                        Drawer.Data.Add(new ViewData(type, player.Name, player.Position, player.Color, player.Origin,
                            player.IsDied, player.Rotation, null, player.Scale));
                    break;
                }
                case "Bullet":
                {
                    if (sprite is Bullet bullet)
                        Drawer.Data.Add(new ViewData(type, bullet.Name, bullet.Position, bullet.Color, bullet.Origin,
                            bullet.IsRemoved, bullet.Rotation, null, bullet.Scale));
                    break;
                }
                case "Sprite":
                {
                    Drawer.Data.Add(new ViewData(type, sprite.Name, sprite.Position, sprite.Color, sprite.Origin));
                    break;
                }
            }

        }
    }
}
