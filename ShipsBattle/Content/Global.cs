using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;

namespace ShipsBattle
{
    public class Global
    {
        public static ContentManager Content;

        public static List<Entity> Entities = new();

        private static readonly List<Entity> ToAdd = new();
        private static readonly List<Entity> ToRemove = new();

        public static void RemoveFromEntities()
        {
            if (ToRemove.Count == 0)
                return;
            foreach (var entity in ToRemove)
            {
                Entities.Remove(entity);
            }
            ToRemove.Clear();
        }

        public static void AddToEntities()
        {
            if(ToAdd.Count == 0)
                return;
            foreach (var entity in ToAdd)
            {
                Entities.Add(entity);
            }
            ToAdd.Clear();
        }

        public static void AddEntity(Entity entity)
        {
            ToAdd.Add(entity);
        }

        public static void RemoveEntity(Entity entity)
        {
            ToRemove.Add(entity);
        }

    }
}
