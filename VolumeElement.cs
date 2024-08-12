using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mohr_Circle
{
    class VolumeElement
    {
        public void StressRVE(PointF[] Edgepoints, PointF[] RotatingMidPoints, Graphics g, Pen p, double Sigma1, double Sigma2)
        {
            AdjustableArrowCap arrowcap = new AdjustableArrowCap(7, 7);
            p.StartCap = LineCap.Flat;
            p.EndCap = LineCap.ArrowAnchor;
            p.CustomEndCap = arrowcap;

            string sSigma = "\u03C3";
            string sTau = "\u03C4";
            string sTheta = "\u03B8";
            string xPrime = "x'";
            string yPrime = "y'";


            PointF midPoint1 = new PointF((Edgepoints[0].X + Edgepoints[1].X) / 2, (Edgepoints[0].Y + Edgepoints[1].Y) / 2);
            PointF midPoint2 = new PointF((Edgepoints[2].X + Edgepoints[1].X) / 2, (Edgepoints[2].Y + Edgepoints[1].Y) / 2);
            PointF midPoint3 = new PointF((Edgepoints[2].X + Edgepoints[3].X) / 2, (Edgepoints[2].Y + Edgepoints[3].Y) / 2);
            PointF midPoint4 = new PointF((Edgepoints[0].X + Edgepoints[3].X) / 2, (Edgepoints[0].Y + Edgepoints[3].Y) / 2);

            
            PointF endPoint1    = RotatingMidPoints[1];
            PointF endPoint2    = RotatingMidPoints[2];
            PointF endPoint3    = RotatingMidPoints[3];
            PointF endPoint4    = RotatingMidPoints[4];
            PointF yyPrimePoint = RotatingMidPoints[5];
            PointF xxPrimePoint = RotatingMidPoints[6];

            int textSize = 9;
            string sSigma1 = sSigma + "1";
            string sSigma2 = sSigma + "2";
             //  string sSigma3 = sSigma + "3";
             // string sSigma4 = sSigma + "4";
             PointF PSigma1 = new PointF(endPoint4.X - 15, endPoint4.Y - 15);
             PointF PSigma2 = new PointF(endPoint3.X - 15, endPoint3.Y + 10);


            if(Sigma1.ToString()!=""&& Sigma2.ToString() != "")
            {
                Anotation(xxPrimePoint, xPrime, g, 9);
                Anotation(yyPrimePoint, yPrime, g, 9);
            }


            if (Sigma1 > 0 && Sigma2 > 0)
            {
                g.DrawLine(p, midPoint1, endPoint1);
                g.DrawLine(p, midPoint2, endPoint2);
                g.DrawLine(p, midPoint3, endPoint3);
                g.DrawLine(p, midPoint4, endPoint4);

                //  Anotation(endPoint3, sSigma, g, textSize);

                

                Anotation(PSigma1, sSigma1, g, textSize);
                Anotation(PSigma2, sSigma2, g, textSize);


            }
            else if (Sigma1 < 0 && Sigma2 < 0)
            {
                g.DrawLine(p, endPoint1, midPoint1);
                g.DrawLine(p, endPoint2, midPoint2);
                g.DrawLine(p, endPoint3, midPoint3);
                g.DrawLine(p, endPoint4, midPoint4);


                //Anotation(endPoint3, sSigma, g, textSize);
                Anotation(PSigma1, sSigma1, g, textSize);
                Anotation(PSigma2, sSigma2, g, textSize);
            }
            else if (Sigma2 > 0 && Sigma1 < 0)
            {
                g.DrawLine(p, midPoint1, endPoint1);
                g.DrawLine(p, endPoint2, midPoint2);
                g.DrawLine(p, midPoint3, endPoint3);
                g.DrawLine(p, endPoint4, midPoint4);
                // Anotation(endPoint3, sSigma, g, textSize);
                Anotation(PSigma1, sSigma1, g, textSize);
                Anotation(PSigma2, sSigma2, g, textSize);
            }
            else if (Sigma2 < 0 && Sigma1 > 0)
            {
                g.DrawLine(p, endPoint1, midPoint1);
                g.DrawLine(p, midPoint2, endPoint2);
                g.DrawLine(p, endPoint3, midPoint3);
                g.DrawLine(p, midPoint4, endPoint4);

                // Point endPoint=(endPoint3[0].X,endPoint3[0].Y)
                // endPoint3 =endPoint3.X
                // Anotation(endPoint3, sSigma, g, textSize);

                Anotation(PSigma1, sSigma1, g, textSize);
                Anotation(PSigma2, sSigma2, g, textSize);
            }
            else if(Math.Floor(Sigma1) == 0  && Sigma2 < 0)
            {
                g.DrawLine(p, endPoint1, midPoint1);
                //g.DrawLine(p, midPoint2, endPoint2);
               g.DrawLine(p, endPoint3, midPoint3);
                // g.DrawLine(p, midPoint4, endPoint4);
               // Anotation(PSigma1, sSigma1, g, textSize);
                Anotation(PSigma2, sSigma2, g, textSize);

            }
            else if(Math.Floor(Sigma1) == 0 && Sigma2 > 0) // Looks like it will never happen 
            {
                g.DrawLine(p, midPoint1, endPoint1);
                //g.DrawLine(p, midPoint2, endPoint2);
                g.DrawLine(p, midPoint3, endPoint3);
                // g.DrawLine(p, midPoint4, endPoint4);

               // Anotation(PSigma1, sSigma1, g, textSize);
               // Point 4==Sigma1
               // Point 3 =Sigma2

                Anotation(PSigma2, sSigma2, g, textSize);
            }
            else if(Math.Floor(Sigma2) == 0 && Sigma1 > 0)
            {
               // g.DrawLine(p, endPoint1, midPoint1);
                g.DrawLine(p, midPoint2, endPoint2);
               // g.DrawLine(p, endPoint3, midPoint3);
                g.DrawLine(p, midPoint4, endPoint4);

                Anotation(PSigma1, sSigma1, g, textSize);
               // Anotation(PSigma2, sSigma2, g, textSize);
            }

        }
        public void ShearRVE(PointF[] Edgepoints, PointF[] RotatingMidPoints, double SigmaAvg, bool isClockwise,Graphics g, Pen p)
        {
            AdjustableArrowCap arrowcap = new AdjustableArrowCap(7, 7);
            p.StartCap = LineCap.Flat;
            p.EndCap = LineCap.ArrowAnchor;
            p.CustomEndCap = arrowcap;

            PointF Point1 = new PointF(Edgepoints[0].X, Edgepoints[0].Y);
            PointF Point2 = new PointF(Edgepoints[1].X, Edgepoints[1].Y);
            PointF Point3 = new PointF(Edgepoints[2].X, Edgepoints[2].Y);
            PointF Point4 = new PointF(Edgepoints[3].X, Edgepoints[3].Y);



            if (isClockwise)
            {
                g.DrawLine(p, Point2, Point1);
                g.DrawLine(p, Point4, Point3);

                g.DrawLine(p, Point2, Point3);
                g.DrawLine(p, Point4, Point1);
            }
            else
            {
                g.DrawLine(p, Point1, Point2);
                g.DrawLine(p, Point3, Point4);

                g.DrawLine(p, Point3, Point2);
                g.DrawLine(p, Point1, Point4);
            }



            PointF midPoint1 = new PointF((Edgepoints[0].X + Edgepoints[1].X) / 2, (Edgepoints[0].Y + Edgepoints[1].Y) / 2);
            PointF midPoint2 = new PointF((Edgepoints[2].X + Edgepoints[1].X) / 2, (Edgepoints[2].Y + Edgepoints[1].Y) / 2);
            PointF midPoint3 = new PointF((Edgepoints[2].X + Edgepoints[3].X) / 2, (Edgepoints[2].Y + Edgepoints[3].Y) / 2);
            PointF midPoint4 = new PointF((Edgepoints[0].X + Edgepoints[3].X) / 2, (Edgepoints[0].Y + Edgepoints[3].Y) / 2);


            PointF endPoint2 = RotatingMidPoints[2];
            PointF endPoint1 = RotatingMidPoints[1];
            PointF endPoint4 = RotatingMidPoints[4];
            PointF endPoint3 = RotatingMidPoints[3];


            if (SigmaAvg > 0)
            {
                g.DrawLine(p, midPoint1, endPoint1);
                g.DrawLine(p, midPoint2, endPoint2);
                g.DrawLine(p, midPoint3, endPoint3);
                g.DrawLine(p, midPoint4, endPoint4);
            }
            else if (SigmaAvg < 0)
            {
                g.DrawLine(p, endPoint1, midPoint1);
                g.DrawLine(p, endPoint2, midPoint2);
                g.DrawLine(p, endPoint3, midPoint3);
                g.DrawLine(p, endPoint4, midPoint4);
            }
            else
            {
                //Draw nothing
            }




        }
        public void Anotation(PointF pt, string symbol,Graphics g, int FontSize)
        {
            Font myFont = new Font("Arial Black", (float)FontSize);
            g.DrawString(symbol,myFont, Brushes.Black, pt);
            

        }

    }
}
