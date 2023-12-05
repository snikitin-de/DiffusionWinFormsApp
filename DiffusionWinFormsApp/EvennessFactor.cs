using Common;

namespace DiffusionWinFormsApp
{
    public class EvennessFactor
    {
        public Side Side;
        public double EvennessFactorValue;

        public EvennessFactor(Side side, double evennessFactor)
        {
            Side = side;
            EvennessFactorValue = evennessFactor;
        }
    }
}
