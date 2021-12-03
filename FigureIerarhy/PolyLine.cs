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

        private Line [] lines;
        public PolyLine(Point[] points, string name)
        {
            Points = points;
            name = string.Concat(points.Select(x => x.DotName));
            Name = name;
            lines = new Line[points.Length];
            lines = CalculateLines();
        }

        virtual public double Perimetr()
        {

            return 0;
        }
      
        virtual public double Square()
        {
            return 0;
        }

        private Line [] CalculateLines()
        {
            for (int i = 0; i <= Points.Length - 2; i++)
            {
                lines[i] = new Line (Points[i],Points[i+1], string.Empty);
            }
            lines[Points.Length-1] = new Line(Points[0], Points[Points.Length - 1], string.Empty);
                return lines;
        }
        public void Draw()
        {

            foreach (Line L in lines)
                L.Draw("*");
           
            
            
            



        }
    }
}
