using System;

namespace FigureIerarhy
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Point[] points = new Point[4];
            points[0] = new Point("a", 1,  1);
            points[1] = new Point("b", 1, 10);
            points[2] = new Point("с", 6, 10);
            points[3] = new Point("d", 6, 1);


          //    Line MyLine = new Line(points[0], points[2], "");
            //  MyLine.Draw("*");
            PolyLine MyPolyFigure = new PolyLine(points,"");
            MyPolyFigure.Draw();
          //  Console.WriteLine(MyLine.Length());
            Console.ReadKey();

        }
    }
}
