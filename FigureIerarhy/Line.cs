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

        private Point[] points;

        private bool IsVertical()
        { 
           bool result = false;
            if ( PointA.Y == PointB.Y) return true; ;
            return result;
        }
        private bool IsGorisontal()
        {
            bool result = false;
            if (PointA.X == PointB.X) return true;
            return result;
        }

        public Line(Point pointA, Point  pointB, string name)
          => (PointA, PointB,Name) = (pointA, pointB, pointA.DotName + pointB.DotName);

        public void Draw(string e)
        {
            foreach (Point dot in CalculateDots())
            {
                dot.Draw(e);
            }
        }
       
        public double Length()
        {
           return Math.Sqrt(Math.Pow(PointA.X - PointB.X, 2) + Math.Pow(PointA.Y - PointB.Y, 2)); ;
        }
       
        private Point [] CalculateDots()
        {

            // Инициализация с расчетом размера массива
            points = new Point[Math.Max( Math.Abs(PointA.X-PointB.X), Math.Abs(PointA.Y - PointB.Y))+1];
            int w = 0;

            
            if (IsGorisontal())
            {
                for (int y = Math.Min(PointA.Y, PointB.Y); y <= Math.Max(PointA.Y, PointB.Y); y++)
                {
                    points[w] = new Point("",PointA.X,y);
                    w++;
                }
                return points;
            }
            if (IsVertical())
            {
                for (int x = Math.Min(PointA.X, PointB.X); x <= Math.Max(PointA.X, PointB.X); x++)
                {
                    points[w] = new Point("", x, PointA.Y);
                    w++;
                }
                return points;

            }

            if (Math.Abs(PointA.X - PointB.X) >= Math.Abs(PointA.Y - PointB.Y))
            {
                //Старт от меньшего к большему X
                for (int x = Math.Min(PointA.X, PointB.X); x <= Math.Max(PointA.X, PointB.X); x++)
                {
                    points[w] = new Point("", x, ((int)Math.Round((double)(-x * (PointA.Y - PointB.Y) - (PointA.X * PointB.Y - PointB.X * PointA.Y)) / (PointB.X - PointA.X))));
                    w++;
                }

                return points;
            }

               //Старт от меньшего к большему Y
            for (int y = Math.Min(PointA.Y, PointB.Y); y <= Math.Max(PointA.Y, PointB.Y); y++)
            {
                 points[w] = new Point("", ((int)Math.Round((double)(-y * (PointB.X - PointA.X) - (PointA.X * PointB.Y - PointB.X * PointA.Y)) / (PointA.Y - PointB.Y))),y);
                w++;
            }

            return points;








        }
    }
}
