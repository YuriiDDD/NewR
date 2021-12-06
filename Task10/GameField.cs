using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class GameField
    {
        public int SizeX { get; init; }
        public int SizeY { get; init; }
        public GameField(int sizex, int sizey)
        {
            SizeX = sizex;
            SizeY = sizey;
            GenerateGameField(SizeX, SizeY);
        }

        public void GenerateGameField(int SizeX, int SizeY)
        {
            for (int x = 0; x <= SizeX; x++)
            {
                Console.SetCursorPosition(0,x);
                Console.Write("x");
                Console.SetCursorPosition(SizeY, x);
                Console.Write("x");
            }
            for (int x = 0; x <= SizeY; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("x");
                Console.SetCursorPosition(x, SizeX);
                Console.Write("x");
            }
        }
    }
}
