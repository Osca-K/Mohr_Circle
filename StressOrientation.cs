using System;

namespace Mohr_Circle
{
    class StressOrientation : StressState
    {

        
        public StressOrientation(double sigmax, double sigmay, double tauxy) : base(sigmax, sigmay, tauxy)
        {
        }
        public double PrincipalOrientation()
        {
            double angle = (Tauxy) / ((Sigmax - Sigmay) / 2);

            return Math.Atan(angle) * 180 / (Math.PI);
        }
        public double InplaneOrientation()
        {
            double angle = -1 * ((Sigmax - Sigmay) / 2) / (Tauxy);

            return Math.Atan(angle) * 180 / (Math.PI);
        }

        public double[] ThetaP()
        {
            double[] thetaP = { PrincipalOrientation()/2, 90-(PrincipalOrientation()/2)  };
            return thetaP;
        }
        public double[] ThetaS()
        {
            double[] thetaP = { InplaneOrientation()/2,90- (InplaneOrientation()/2)  };
            return thetaP;
        }


    }
}
