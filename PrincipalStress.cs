using System;

namespace Mohr_Circle
{
    class PrincipalStress
    {
        private double sigma1;
        private double sigma2;
        private double avgSigma;
        private double radius;
        private bool isValueSet;

        public double AvgSigma { get { return avgSigma; } }
        public double Sigma1
        {
            get { return sigma1; }
            private set
            { sigma1 = value; }
        }

        public double Sigma2
        {
            get { return sigma2; }
            private set
            { sigma2 = value; }
        }
        public bool IsVauleSet { get { return isValueSet; } }
        public double SigmaAverage(StressState GivenState)
        {
            double x = GivenState.Sigmax;
            double y = GivenState.Sigmay;
            double z = (x + y) / 2.0;
            avgSigma = z;
            return z;
        }
        public double Radius(StressState GivenState)
        {
            double x = GivenState.Sigmax - avgSigma;
            double y = GivenState.Tauxy;
            double Radius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            radius = Radius;
            return radius;
        }

        public void PrincipalStressess()
        {
            sigma1 = Math.Max(avgSigma + radius, avgSigma - radius);
            sigma2 = Math.Min(avgSigma + radius, avgSigma - radius);
        }


        public double[] CenterPoints()
        {
            double[] C = { avgSigma, 0 };
            return C;
        }
        public double[] CircumferencePoints(StressState GivenState)
        {
            double[] A = { GivenState.Sigmax, GivenState.Tauxy };
            return A;
        }
        public bool SetUpValues(StressState GivenState)
        {
            SigmaAverage(GivenState);
            Radius(GivenState);
            PrincipalStressess();
            CircumferencePoints(GivenState);
            isValueSet = true;
            return isValueSet;
        }
    }
}
