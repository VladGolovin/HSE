using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyPaint
{
    using System.Drawing;

    public static class GraphicsExtensions
    {
        public static void DrawStar(this Graphics graphics, Pen pen, int pointCount, int radius, int ox, int oy)
        {
            var points = new List<Point>();

            var points1 = new List<Point>();

            double increment = Math.PI * 2 / pointCount;

            double i1 = increment;

            for (double i = 0; i < Math.PI*2; i = i + increment)
            {
                double x = ox + radius * Math.Sin(i);

                double y = oy + radius * Math.Cos(i);

                double x1 = ox + radius / 2 * Math.Sin(i1);

                double y1 = oy + radius / 2 * Math.Cos(i1);

                points.Add(new Point(Convert.ToInt32(x), Convert.ToInt32(y)));

                points1.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));

                i1 += increment;
            }

            graphics.DrawPolygon(pen, points.ToArray());
            graphics.DrawPolygon(pen, points1.ToArray());
        }
    }
}
