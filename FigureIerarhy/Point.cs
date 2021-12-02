using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureIerarhy
{
    class Point
    {
        public Point (string dotname, int x,int y)
            => (DotName,X,Y) = (dotname,x,y);
        public string DotName { get; init; }
        public int X {get; init; }
        public int Y { get; init; }
         public void Draw(string s)
        {
            try
            {
                Console.SetCursorPosition(X,Y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }


    }
}
