namespace Mohr_Circle
{
    class StressState
    {
        readonly private double sigmax;
        readonly private double sigmay;
        readonly private double tauxy;

        public StressState(double sigmax, double sigmay, double tauxy)
        {
            this.sigmax = sigmax;
            this.sigmay = sigmay;
            this.tauxy = tauxy;
        }
        public double Sigmax { get { return sigmax; } }
        public double Sigmay { get { return sigmay; } }
        public double Tauxy { get { return tauxy; } }
    }
}
