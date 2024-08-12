using System;


namespace Mohr_Circle
{
      class PlainStressTransformationEquations 
      {
        public double SigmaxPrime(double sigmax,double sigmay,double tauxy,double orientation)
        {
            double c = Math.PI / 180;
            double sigmaxPrime = ((sigmax + sigmay) / 2.0) + (((sigmax - sigmay) / 2.0) * Math.Cos(2 * orientation * c)) + tauxy * Math.Sin(2 * orientation * c);
            return sigmaxPrime;
        }
        public double TauxyPrime(double sigmax, double sigmay, double tauxy, double orientation)
        {
            double c = Math.PI / 180;
            // Remember this mistake almost cost you everything (gotta pay attention to ur sign 
            double  tauxyPrime=(-((sigmax - sigmay) / 2.0) * Math.Sin(2 * orientation * c)) + tauxy * Math.Cos(2 * orientation * c);
            return tauxyPrime;
        }

      }
}
