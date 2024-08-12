using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mohr_Circle
{
    public partial class Form1 : Form
    {

        double Sigma1;
        double Sigma2;
        double SigmaAvg;
        double ThetaP1;
        double ThetaS1;
        bool isClockwise;
        
        public Form1()
        {
            InitializeComponent();

            //Adding initial default values in SI unit 
            txtX.Text = "80";
            txtY.Text = "120";
            txtXY.Text = "40";
            cmbX.Text =  "Tension";
            cmbY.Text = "Compression";
            cmbXY.Text = "Clockwise";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //To exit the project
            Application.Exit();
        }
        private void ClearInputs()
        {
          //Incase user wanna put their own values
            txtX.Text = txtY.Text = txtXY.Text = "";
            cmbX.Text = cmbY.Text = cmbXY.Text = "";
            pnlCanva.Refresh();
        }
        private void MohrClicle()
        {
            pnlCanva.Refresh();
            double Sigmax = Math.Abs(Convert.ToDouble(txtX.Text));
            double Sigmay = Math.Abs(Convert.ToDouble(txtY.Text));
            double TauXY  = Math.Abs(Convert.ToDouble(txtXY.Text));

            if (cmbX.SelectedItem.ToString() == "Compression") Sigmax = -Sigmax ;
            if (cmbY.SelectedItem.ToString() == "Compression") Sigmay = -Sigmay ;
            if (cmbXY.SelectedItem.ToString() == "Clockwise")  TauXY  = -TauXY;


            StressState GivenStateElement = new StressState(Sigmax , Sigmay, TauXY);
            StressOrientation Orientation = new StressOrientation(Sigmax, Sigmay, TauXY);
            PrincipalStress PStress = new PrincipalStress();
            PlainStressTransformationEquations PSTE = new PlainStressTransformationEquations();
            Graphics g = pnlCanva.CreateGraphics();
            double xcenter = pnlCanva.Width / 2;
            double ycenter = pnlCanva.Height / 2;

            Pen blackPen = new Pen(Color.Black);
            Pen redPen = new Pen(Color.Red,2);
            Brush blue = new SolidBrush(Color.AliceBlue);
            Pen purplePen = new Pen(Color.Purple);
            Pen violetPen = new Pen(Color.Violet,2);
            Pen yellowPen = new Pen(Color.Yellow,2);

  

            if (PStress.IsVauleSet != true) PStress.SetUpValues(GivenStateElement); 

            double[] A = PStress.CenterPoints();
            double[] B = PStress.CircumferencePoints(GivenStateElement);
            double radius = PStress.Radius(GivenStateElement);

            // New coordinates relative to the panel

            double[] C = { xcenter + A[0], ycenter + A[1]};

        

            double[] P = { xcenter + B[0], ycenter + B[1] };
      
            double[] F = { C[0],C[1],P[0],P[1] };

            double[] CP = { C[0] - radius, C[1] - radius, 2 * radius, 2 * radius };


            XYaxis(blackPen, g, xcenter, ycenter);

            CenterToPoint(redPen, g, F);

            CirculeAroundCenter(redPen, g, CP);

            double [] angles = Angles(GivenStateElement, PSTE, PStress, Orientation);

            double PAngle = ReduceAngles(angles[0]);
            double SAngle = ReduceAngles(angles[1]);
             


            MaximumShearStress(purplePen, g, F, radius);

            PrincipalStresses(yellowPen, violetPen, g, F, radius);


            Sigma1 = PStress.Sigma1;
            Sigma2 = PStress.Sigma2;
            SigmaAvg = PStress.AvgSigma;
            ThetaP1 = PAngle;
            ThetaS1 = SAngle;




            string sSigma = "\u03C3";
            string sTau = "\u03C4";
            string sTheta = "\u03B8";


            lblSigmaAvg.Text = String.Format($"Sigam Avarage : {PStress.AvgSigma.ToString("F")}");
            lblCenterP.Text=   String.Format($"Center Point  : ({A[0].ToString("F")} ; {A[1].ToString("F")})");
            lblPoint.Text = String.Format($"Circumf Point  : ({B[0].ToString("F")} ; {B[1].ToString("F")})");
            lblRadius.Text=    String.Format("Radius : {0}",radius.ToString("F"));
            lblPstress.Text= String.Format($" Principal  : {sSigma}1 = {PStress.Sigma1.ToString("F")}  {sSigma}2= {PStress.Sigma2.ToString("F")})");
            lblSStress.Text = String.Format($"{sTau}max Shear : {radius.ToString("F")} ");

            lblAngles.Text = String.Format($" {sTheta}p1 = {PAngle.ToString("F")}   {sTheta}s1={SAngle.ToString("F")})");
        }
      

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //Drwaing mohrCicle 
            tabControl.SelectedTab = tabMohrCicle;
            MohrClicle();
        }
        private void Construction() { }
        private void XYaxis(Pen Pen,Graphics g,double xcenter,double ycenter) 
        {
            
            g.DrawLine(Pen, (float)(0), (float)(ycenter), (float)xcenter * 2, (float)ycenter);
           
            g.DrawLine(Pen, (float)(xcenter), (float)(0), (float)xcenter, (float)ycenter * 2);
        }
        private void CenterToPoint(Pen Pen,Graphics g, double[] F)
        {
            g.DrawLine(Pen, (float)(F[0]), (float)(F[1]), (float)(F[2]), (float)(F[3]));
        }
        private void CirculeAroundCenter(Pen Pen, Graphics g, double[] CP)
        {
            g.DrawEllipse(Pen, (float)(CP[0]), (float)(CP[1]), (float)(CP[2]), (float)(CP[3]));
        }
        private void MaximumShearStress(Pen Pen, Graphics g, double[] F,double radius )
        { 
            g.DrawLine(Pen, (float)(F[0]), (float)(F[1]), (float)(F[0]), (float)(F[1] + radius));
        }
        private void PrincipalStresses(Pen Pen1,Pen Pen2, Graphics g, double[] F, double radius)
        {
            g.DrawLine(Pen1, (float)(F[0]), (float)(F[1]), (float)(F[0]-radius), (float)(F[1]));

            g.DrawLine(Pen2, (float)(F[0]), (float)(F[1]), (float)(F[0]+radius), (float)(F[1]));
        }

        private double [] Angles(StressState GivenStateElement,PlainStressTransformationEquations PSTE, PrincipalStress PS,StressOrientation orientation )
        {

            PlainStressTransformationEquations PST = new PlainStressTransformationEquations();
            double thetaP1;
            double thetaS1;
            double[] p = orientation.ThetaP();
            double[] s = orientation.ThetaS();

            double SigmaPrime = PST.SigmaxPrime(GivenStateElement.Sigmax, GivenStateElement.Sigmay, GivenStateElement.Tauxy, p[0]);
            double Sigma1 = PS.Sigma1;

            double TauPrime=PST.TauxyPrime(GivenStateElement.Sigmax, GivenStateElement.Sigmay, GivenStateElement.Tauxy, s[0]);
            double MaxShearStress = PS.Radius(GivenStateElement);

            if (Math.Round(SigmaPrime) == Math.Round(Sigma1)) 
                thetaP1 = p[0];
            else 
                thetaP1 = p[1];

            if (Math.Round(TauPrime) == Math.Round(MaxShearStress))
            {
                thetaS1 = s[0];
                isClockwise = false; 
            }
            else
            {
                thetaS1 = s[1];
                isClockwise = true;
            }
            double[] angles = { thetaP1, thetaS1 };
            return angles;

        }
        private void btnRVE_Click(object sender, EventArgs e)
        {
           tabControl.SelectedTab = tabRVE;
           Graphics x = pnlRVE.CreateGraphics();
           

           double xcenter = pnlRVE.Width / 2;
           double ycenter = pnlRVE.Height / 4;

           double[] xTop = { 0, ycenter, xcenter * 2, ycenter };
           double[] xBot = { 0, ycenter * 3, xcenter*2, ycenter * 3 };

           Pen blackPen = new Pen(Color.Black);

       
           x.DrawLine(blackPen, (float)xTop[0], (float)xTop[1], (float)xTop[2], (float)xTop[3]);
           x.DrawLine(blackPen, (float)xBot[0], (float)xBot[1], (float)xBot[2], (float)xBot[3]);
           x.DrawLine(blackPen, (float)xcenter, (float)(0), (float)(xcenter), (float)ycenter * 4);

           RepresentedVolumeElement();

        }
        private void RepresentedVolumeElement()
        {
            Graphics g = pnlRVE.CreateGraphics();
            Pen greenPen = new Pen(Color.Green);
            Pen redPen = new Pen(Color.Red,2);
            Brush pinkBrush = new SolidBrush(Color.LightPink);
            Pen purplePen = new Pen(Color.Purple,2);
            Pen violetPen = new Pen(Color.Violet,3);
 
            double xcenter = pnlRVE.Width / 2;
            double ycenter = pnlRVE.Height / 4;

            double ShearConnerPointsSize = 6000;
            double connerSize = 5000;
            double rotatingXYsize = 12000;
            double xyLength = 18000;

            Coordinates coordinate = new Coordinates();
            VolumeElement RVE = new VolumeElement();


            PointF[] SressElement = coordinate.FourConnerPoints(-ThetaP1, xcenter, ycenter, connerSize);
            PointF[] ShearElement = coordinate.FourConnerPoints(-ThetaS1, xcenter, ycenter * 3, connerSize);
            PointF[] ShearPoints = coordinate.FourConnerPoints(-ThetaS1, xcenter, ycenter * 3, ShearConnerPointsSize);


            DrawRotatingXY(coordinate.RotatingPlanePoint(-ThetaP1, xcenter, ycenter, xyLength), g, purplePen,RVE);
            DrawRotatingXY(coordinate.RotatingPlanePoint(-ThetaS1, xcenter, ycenter*3, xyLength), g, purplePen,RVE);

            g.FillPolygon(pinkBrush, SressElement);
            g.DrawPolygon(greenPen, SressElement);

            g.FillPolygon(pinkBrush, ShearElement);
            g.DrawPolygon(greenPen, ShearElement);


            RVE.StressRVE(SressElement, coordinate.RotatingPlanePoint(-ThetaP1, xcenter, ycenter, rotatingXYsize), g, redPen,Sigma1,Sigma2);
            ArcAngles(g, violetPen, xcenter, ycenter, -ThetaP1);

            RVE.ShearRVE(ShearPoints, coordinate.RotatingPlanePoint(-ThetaS1, xcenter, ycenter * 3, rotatingXYsize),SigmaAvg,isClockwise,g,redPen);
            ArcAngles(g, violetPen, xcenter, ycenter*3, -ThetaS1);

        }
        private void ToBeRemoved() 
        {
            /*
       private void ShearRVE(PointF [] Edgepoints,PointF [] RotatingMidPoints,Graphics g, Pen p )
       {
           AdjustableArrowCap arrowcap = new AdjustableArrowCap(5, 5);
           p.StartCap = LineCap.Flat;
           p.EndCap = LineCap.ArrowAnchor;
           p.CustomEndCap = arrowcap;

           PointF Point1 = new PointF(Edgepoints[0].X,Edgepoints[0].Y);
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



           PointF midPoint1 = new PointF((Edgepoints[0].X + Edgepoints[1].X)/2, (Edgepoints[0].Y + Edgepoints[1].Y)/2);
           PointF midPoint2 = new PointF((Edgepoints[2].X + Edgepoints[1].X)/2, (Edgepoints[2].Y + Edgepoints[1].Y)/2);
           PointF midPoint3 = new PointF((Edgepoints[2].X + Edgepoints[3].X)/2, (Edgepoints[2].Y + Edgepoints[3].Y)/2);
           PointF midPoint4 = new PointF((Edgepoints[0].X + Edgepoints[3].X)/2, (Edgepoints[0].Y + Edgepoints[3].Y)/2);


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
       private void StressRVE(PointF[] Edgepoints, PointF[] RotatingMidPoints, Graphics g, Pen p,double Sigma1,double Sigma2)
       {
           AdjustableArrowCap arrowcap = new AdjustableArrowCap(5, 5);
           p.StartCap = LineCap.Flat;
           p.EndCap = LineCap.ArrowAnchor;
           p.CustomEndCap = arrowcap;


           PointF midPoint1 = new PointF((Edgepoints[0].X + Edgepoints[1].X) / 2, (Edgepoints[0].Y + Edgepoints[1].Y) / 2);
           PointF midPoint2 = new PointF((Edgepoints[2].X + Edgepoints[1].X) / 2, (Edgepoints[2].Y + Edgepoints[1].Y) / 2);
           PointF midPoint3 = new PointF((Edgepoints[2].X + Edgepoints[3].X) / 2, (Edgepoints[2].Y + Edgepoints[3].Y) / 2);
           PointF midPoint4 = new PointF((Edgepoints[0].X + Edgepoints[3].X) / 2, (Edgepoints[0].Y + Edgepoints[3].Y) / 2);

           PointF endPoint2 = RotatingMidPoints[2];
           PointF endPoint1 = RotatingMidPoints[1];
           PointF endPoint4 = RotatingMidPoints[4];
           PointF endPoint3 = RotatingMidPoints[3];


           if(Sigma1 >0 && Sigma2 > 0)
           {
               g.DrawLine(p, midPoint1, endPoint1);
               g.DrawLine(p, midPoint2, endPoint2);
               g.DrawLine(p, midPoint3, endPoint3);
               g.DrawLine(p, midPoint4, endPoint4);

           }
           else if(Sigma1<0 && Sigma2 < 0)
           {
               g.DrawLine(p, endPoint1, midPoint1);
               g.DrawLine(p, endPoint2, midPoint2);
               g.DrawLine(p, endPoint3, midPoint3);
               g.DrawLine(p, endPoint4, midPoint4);
           }
           else if(Sigma2>0 && Sigma1 < 0)
           {
               g.DrawLine(p, midPoint1, endPoint1);
               g.DrawLine(p, endPoint2, midPoint2);
               g.DrawLine(p, midPoint3, endPoint3);
               g.DrawLine(p, endPoint4, midPoint4);
           }
           else if(Sigma2<0 && Sigma1 > 0)
           {
               g.DrawLine(p, endPoint1, midPoint1);
               g.DrawLine(p, midPoint2, endPoint2);
               g.DrawLine(p, endPoint3, midPoint3);
               g.DrawLine(p, midPoint4, endPoint4);
           }

       }
       private PointF [] FourConnerPoints(double angle,double xcenter,double ycenter,double size)
       {
           PointF p1 = new PointF((float)XYCoordinates(angle-45,   xcenter, ycenter,size)[0], (float)XYCoordinates(angle-45, xcenter, ycenter,size)[1]);
           PointF p2 = new PointF((float)XYCoordinates(angle + 45, xcenter, ycenter,size)[0], (float)XYCoordinates(angle + 45, xcenter, ycenter,size)[1]);
           PointF p3 = new PointF((float)XYCoordinates(angle + 135, xcenter, ycenter,size)[0], (float)XYCoordinates(angle + 135, xcenter, ycenter,size)[1]);
           PointF p4 = new PointF((float)XYCoordinates(angle + 225, xcenter, ycenter,size)[0], (float)XYCoordinates(angle + 225, xcenter, ycenter,size)[1]);
           PointF[] point = { p1, p2, p3, p4 };

           return point;
       }

       private double[] XYCoordinates(double angle, double xcenter, double ycenter,double size)
       {
           angle %= 360;
           angle *= 1;
           double[] xy = new double[2];

           double c = Math.PI / 180;

           if(angle>=0 && angle <= 180)
           {
               xy[0] =( xcenter + Math.Sqrt(size) * Math.Sin(angle * c));
               xy[1] = (ycenter - Math.Sqrt(size) * Math.Cos(angle * c));
           }
           else
           {
               xy[0] = (xcenter - Math.Sqrt(size) * Math.Sin(angle * c) * -1);
               xy[1] = (ycenter - Math.Sqrt(size) * Math.Cos(angle * c));
           }

           return xy;
       }
       private PointF [] RotatingPlanePoint( double angle,double xcenter,double ycenter,double size )
       {
           double x1 = XYCoordinates(angle, xcenter, ycenter, size)[0];
           double y1 = XYCoordinates(angle, xcenter, ycenter, size)[1];

           double x2 = XYCoordinates(angle+90, xcenter, ycenter, size)[0];
           double y2 = XYCoordinates(angle+90, xcenter, ycenter, size)[1];

           double x3 = XYCoordinates(angle + 180, xcenter, ycenter, size)[0];
           double y3 = XYCoordinates(angle + 180, xcenter, ycenter, size)[1];

           double x4 = XYCoordinates(angle + 270, xcenter, ycenter, size)[0];
           double y4 = XYCoordinates(angle + 270, xcenter, ycenter, size)[1];


           PointF Center = new PointF((float)xcenter, (float)ycenter);
           PointF xPrimePos = new PointF((float)x1, (float)y1);
           PointF yPrimePos = new PointF((float)x2, (float)y2);
           PointF xPrimeNeg = new PointF((float)x3, (float)y3);
           PointF yPrimeNeg = new PointF((float)x4, (float)y4);

           PointF[] Point = { Center, xPrimePos, yPrimePos,xPrimeNeg,yPrimeNeg };
           return Point;

       }*/
        }


        private void DrawRotatingXY(PointF [] pt,Graphics g,Pen p, VolumeElement VE)
        {

            PointF yAxisEdge = new PointF(pt[1].X-5,pt[1].Y-18);
            PointF xAxisEdge = new PointF(pt[2].X-5, pt[2].Y);




          // g.DrawLine(p,)

            g.DrawLine(p, pt[0], pt[1]);
            g.DrawLine(p, pt[0], pt[2]);

          //  VE.Anotation(xAxisEdge, "x'", g, 9);
           // VE.Anotation(yAxisEdge, "y'", g, 9);



        }
        private void Labels()
        {

        }
        private void ArcAngles(Graphics g, Pen p, double xcenter,double ycenter,double angle)
        {
            double xStart=xcenter ;
            double yStart=ycenter ;

            AdjustableArrowCap arrowcap = new AdjustableArrowCap(5, 5);
            p.StartCap = LineCap.ArrowAnchor;
            p.EndCap = LineCap.ArrowAnchor;
            p.CustomEndCap = arrowcap;
            g.DrawArc(p, (float)xStart-90, (float)yStart-95, (float)xStart,(float)xStart,0, (float)angle);
          
        } 
        private double ReduceAngles(double angle)
        {
            double reducedAngle;

            if (angle > 90) reducedAngle = 90 - angle;
            
            else reducedAngle = angle;
            
            return reducedAngle;
        }
    }
    
}
