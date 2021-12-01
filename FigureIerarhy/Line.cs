using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureIerarhy
{
    class Line
    {
        public string Name { get; init; }
        public Point PointA { get; init; }
        public Point PointB { get; init; }

        public Line(Point pointA, Point  pointB, string name)
          => (PointA, PointB,Name) = (pointA, pointB, name = pointA.DotName + pointB.DotName);

      

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        virtual public double Length()
        {
           return Math.Sqrt(Math.Pow(PointA.X - PointB.X, 2) + Math.Pow(PointA.Y - PointB.Y, 2)); ;
        }
       
        virtual public void Draw(string kirpichik)
        {

            int start; 
            int finish;
            
            //If vertical line
            if (PointA.Y == PointB.Y)
            {
                start = PointA.X;
                finish = PointB.X;
                //Если точки заданы в другом порядке меняю местами
                if (start > finish)
                {
                    start = PointB.X;
                    finish = PointA.X;
                }
                for (int x = start; x <= finish; x++)
                    //    Console.WriteLine(((int)Math.Round((double)(-y * (PointB.X - PointA.X) - (PointA.X * PointB.Y - PointB.X * PointA.Y)) / (PointA.Y - PointB.Y))));
                    WriteAt(kirpichik, ((int)Math.Round((double)(-x * (PointA.Y - PointB.Y) - (PointA.X * PointB.Y - PointB.X * PointA.Y)) / (PointB.X - PointA.X))),x);

            }
            //All other lines
            else
            {
            start = PointA.Y;
            finish = PointB.Y;
                //Если точки заданы в другом порядке меняю местами
                if (start > finish)
                {
                    start = PointB.Y;
                    finish = PointA.Y;
                }
                for (int y = start; y <= finish; y++)
                    //    Console.WriteLine(((int)Math.Round((double)(-y * (PointB.X - PointA.X) - (PointA.X * PointB.Y - PointB.X * PointA.Y)) / (PointA.Y - PointB.Y))));
                    WriteAt(kirpichik, y, ((int)Math.Round((double)(-y * (PointB.X - PointA.X) - (PointA.X * PointB.Y - PointB.X * PointA.Y)) / (PointA.Y - PointB.Y))));

            }






           
        }
    }
}
