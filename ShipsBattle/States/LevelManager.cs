using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ShipsBattle
{
    public class LevelManager
    {
        public static List<Sprite> Sprites { get; private set; }
        public static string BackgroundName { get; private set; }


        public static void UploadLevel()
        {
            Global.Sprites = Sprites;
        }

        public static void LoadTutorialLevel()
        {
            Sprites = new List<Sprite>()
            {
                new Player(
                    "Player1", 
                    new(100, 100), 
                    Drawer.Sprites["Player"].Height,
                    Drawer.Sprites["Player"].Width, 
                    new(0, 1), 
                    new Input
                    {
                        Down = Keys.S,
                        Up = Keys.W,
                        Left = Keys.A,
                        Right = Keys.D,
                        RotateLeft = Keys.Q,
                        RotateRight = Keys.E,
                        Shoot = Keys.R
                    }),

                new Player(
                    "Player2",
                    new(500, 500),
                    Drawer.Sprites["Player"].Height,
                    Drawer.Sprites["Player"].Width,
                    new(0, -1),
                    new Input
                    {
                        Down = Keys.K,
                        Up = Keys.I,
                        Left = Keys.J,
                        Right = Keys.L,
                        RotateLeft = Keys.U,
                        RotateRight = Keys.O,
                        Shoot = Keys.P
                    }),
            };

            BackgroundName = "space-stars";
        }

        public void LoadFirstLevel()
        {
        }

        public void LoadSecondLevel()
        {
        }

        public void LoadThirdLevel()
        {
        }
    }
}