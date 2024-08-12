using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mohr_Circle
{
    class Coordinates
    {

        public PointF[] FourConnerPoints(double angle, double xcenter, double ycenter, double size)
        {
            PointF p1 = new PointF((float)XYCoordinates(angle - 45, xcenter, ycenter, size)[0], (float)XYCoordinates(angle - 45, xcenter, ycenter, size)[1]);
            PointF p2 = new PointF((float)XYCoordinates(angle + 45, xcenter, ycenter, size)[0], (float)XYCoordinates(angle + 45, xcenter, ycenter, size)[1]);
            PointF p3 = new PointF((float)XYCoordinates(angle + 135, xcenter, ycenter, size)[0], (float)XYCoordinates(angle + 135, xcenter, ycenter, size)[1]);
            PointF p4 = new PointF((float)XYCoordinates(angle + 225, xcenter, ycenter, size)[0], (float)XYCoordinates(angle + 225, xcenter, ycenter, size)[1]);
            PointF[] point = { p1, p2, p3, p4 };

            return point;
        }
        private double[] XYCoordinates(double angle, double xcenter, double ycenter, double size)
        {
            angle %= 360;
            angle *= 1;
            double[] xy = new double[2];

            double c = Math.PI / 180;

            if (angle >= 0 && angle <= 180)
            {
                xy[0] = (xcenter + Math.Sqrt(size) * Math.Sin(angle * c));
                xy[1] = (ycenter - Math.Sqrt(size) * Math.Cos(angle * c));
            }
            else
            {
                xy[0] = (xcenter - Math.Sqrt(size) * Math.Sin(angle * c) * -1);
                xy[1] = (ycenter - Math.Sqrt(size) * Math.Cos(angle * c));
            }

            return xy;
        }

        public PointF[] RotatingPlanePoint(double angle, double xcenter, double ycenter, double size)
        {
            double x1 = XYCoordinates(angle, xcenter, ycenter, size)[0];
            double y1 = XYCoordinates(angle, xcenter, ycenter, size)[1];

            double x2 = XYCoordinates(angle + 90, xcenter, ycenter, size)[0];
            double y2 = XYCoordinates(angle + 90, xcenter, ycenter, size)[1];

            double x3 = XYCoordinates(angle + 180, xcenter, ycenter, size)[0];
            double y3 = XYCoordinates(angle + 180, xcenter, ycenter, size)[1];

            double x4 = XYCoordinates(angle + 270, xcenter, ycenter, size)[0];
            double y4 = XYCoordinates(angle + 270, xcenter, ycenter, size)[1];


            double xx1 = XYCoordinates(angle, xcenter, ycenter, size+ 8025)[0];
            double yy1 = XYCoordinates(angle, xcenter, ycenter, size+ 7085)[1];

            double xx2 = XYCoordinates(angle + 90, xcenter, ycenter, size+8025)[0];
            double yy2 = XYCoordinates(angle + 90, xcenter, ycenter, size+ 7085)[1];







            PointF Center =    new PointF((float)xcenter, (float)ycenter);
            PointF xPrimePos = new PointF((float)x1, (float)y1);
            PointF yPrimePos = new PointF((float)x2, (float)y2);
            PointF xPrimeNeg = new PointF((float)x3, (float)y3);
            PointF yPrimeNeg = new PointF((float)x4, (float)y4);
            PointF xPrimeLabel=new PointF((float)xx1, (float)yy1);
            PointF yPrimeLabel= new PointF((float)xx2, (float)yy2);

            PointF[] Point = { Center, xPrimePos, yPrimePos, xPrimeNeg, yPrimeNeg, xPrimeLabel, yPrimeLabel };
            return Point;
        }

    }
   

    
}
