using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//[DllImport("user32.dll")]


namespace Task10
{
    class Game
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int key);

        private const int Left = 0x25;
        private const int Down = 0x28;
        private const int UP = 0x26;
        private const int Right = 0x27;

        public void Play()
        {
            GameField GF = new GameField(29, 119);
            Snake mySnake = new Snake(2,2, 1);
            bool GameOn = true;
            int direction = 1;
            int key = 0;
            int i = 0;
            while (true) // Бесконечный цикл.
            {
                bool L = (GetAsyncKeyState(Right)) != 0;
                bool R = (GetAsyncKeyState(Left)) != 0;
                bool U = (GetAsyncKeyState(UP)) != 0;
                bool D = (GetAsyncKeyState(Down)) != 0;
                if (L)
                {
                    direction = 2;
                  // Console.WriteLine("The key is left");
                    
                }
                if (R)
                {
                    direction = 1;
                   // Console.WriteLine("The key is right");

                }
                if (U) direction = 3;
                if (D) direction = 4;


                //  Print(points, choose);
                //switch (Console.ReadKey(true).Key)
                //{
                //    case ConsoleKey.RightArrow: direction = 1; ; break;
                //    case ConsoleKey.LeftArrow: direction = 2; break;
                //    case ConsoleKey.UpArrow: direction = 3; break;
                //    case ConsoleKey.DownArrow: direction = 4; break;

                //}
                  mySnake.Move(direction);


            }
        }
    }
}
