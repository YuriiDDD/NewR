using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureIerarhy
{
    class PolyLine
    {
        public string Name { get; init; }
        public Point[] Points { get; init; }
       
        public PolyLine(Point[] points,string name)
          => (Points, Name) = (points, name= string.Concat(points.Select(x=>x.DotName))) ;
  
       

        virtual public double Perimetr()
        {

            return 0;
        }
      
        virtual public double Square()
        {
            return 0;
        }
        public void Draw()
        {
            Line MyLine;
            //Рисую все линии кроме последней
            for (int i=0;i<=Points.Length-2; i++)
            {
                MyLine = new Line(Points[i], Points[i + 1], "");
                MyLine.Draw("*");
            }
            ////Connect first and last dots
            MyLine = new Line(Points[0], Points[Points.Length-1], "");
            MyLine.Draw("*");



        }
    }
}
