using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Snake
    {
        public Snake (int x, int y, int size)
           => (X, Y, Size) = (x, y, size);
        
        
        public int Size { get; init; }
       
        
        public int X { get; set; }
        public int Y { get; set; }



        public void Move(int Direction)
        {
            EraseSnake(X, Y);
            int LastX = X; int LastY = Y;
            switch (Direction)
            {
                case 1: X++;  break;
                case 2: X--; break;
                case 3: Y++; break;
                case 4: Y--; break;
            
            }
            Draw(LastX, LastY);
        
        }

    
        private void Draw(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write('*');
        }
        private void EraseSnake(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

        private void SnakeGrow()
        { 
        
        }

        public bool isCrash()
        {



            return true;
        
        }
    }
}
