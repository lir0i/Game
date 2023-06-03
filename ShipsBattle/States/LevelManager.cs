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
            Global.BackgroundName = BackgroundName;
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
                    },
                    1.4f,
                    8,
                    Color.DeepPink
                    ),

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
                    },
                    1.4f,
                    8,
                    Color.White
                ),
                new Asteroid("asteroid",
                    new Vector2(1000, 100),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.4f, 
                    1f, 
                    true),
                new Asteroid("asteroid",
                    new Vector2(1000,500),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.1f,
                    1f,
                    false)
            };

            BackgroundName = "space";
        }

        public static void LoadFirstLevel()
        {
            Sprites = new List<Sprite>()
            {
                new Player(
                    "Player1",
                    new(100, 500),
                    Drawer.Sprites["Player"].Height,
                    Drawer.Sprites["Player"].Width,
                    new(0, 0),
                    new Input
                    {
                        Down = Keys.S,
                        Up = Keys.W,
                        Left = Keys.A,
                        Right = Keys.D,
                        RotateLeft = Keys.Q,
                        RotateRight = Keys.E,
                        Shoot = Keys.R
                    },
                    2f,
                    8,
                    Color.DeepPink
                ),

                new Player(
                    "Player2",
                    new(1600, 500),
                    Drawer.Sprites["Player"].Height,
                    Drawer.Sprites["Player"].Width,
                    new(0, 0),
                    new Input
                    {
                        Down = Keys.K,
                        Up = Keys.I,
                        Left = Keys.J,
                        Right = Keys.L,
                        RotateLeft = Keys.U,
                        RotateRight = Keys.O,
                        Shoot = Keys.P
                    },
                    2f,
                    8,
                    Color.White
                ),

                new Asteroid("asteroid",
                    new Vector2(900, 500),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.4f,
                    1f,
                    true),
                new Asteroid("asteroid",
                    new Vector2(900, 300),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.5f,
                    1f,
                    true),
                new Asteroid("asteroid",
                    new Vector2(900, 100),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.1f,
                    1f,
                    true),
                new Asteroid("asteroid",
                    new Vector2(900, 700),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.2f,
                    1f,
                    true),
                new Asteroid("asteroid",
                    new Vector2(900, 900),
                    Drawer.Sprites["Asteroid"].Height,
                    Drawer.Sprites["Asteroid"].Width,
                    new Vector2(0, 0),
                    0.2f,
                    1f,
                    true),

            };

            BackgroundName = "space-stars";
        }

        public static void LoadSecondLevel()
        {
        }

        public static void LoadThirdLevel()
        {
        }
    }
}