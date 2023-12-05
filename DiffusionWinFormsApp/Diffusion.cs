using Common;

namespace DiffusionWinFormsApp
{
    public class Diffusion
    {
        private int topCountHitted;
        private int bottomCountHitted;
        private int leftCountHitted;
        private int rightCountHitted;
        private int width;
        private int height;
        private double epsilon;

        public Diffusion(int topCountHitted, int bottomCountHitted, int leftCountHitted, int rightCountHitted, int width, int height, double epsilon)
        {
            this.topCountHitted = topCountHitted;
            this.bottomCountHitted = bottomCountHitted;
            this.leftCountHitted = leftCountHitted;
            this.rightCountHitted = rightCountHitted;
            this.width = width;
            this.height = height;
            this.epsilon = epsilon;
        }

        private double CalculateEvennessFactor(int wallCountHitted, int wallLength)
        {
            return Math.Round(wallCountHitted / (double)wallLength, 4);
        }

        private bool EqualTo(double value1, double value2, double epsilon)
        {
            return Math.Abs(value1 - value2) < epsilon;
        }

        public List<EvennessFactor> CalculateEvennessFactor()
        {
            var evennessFactors = new List<EvennessFactor>();
            var topEvenessFactor = CalculateEvennessFactor(topCountHitted, width);
            var bottomEvenessFactor = CalculateEvennessFactor(bottomCountHitted, width);
            var leftEvenessFactor = CalculateEvennessFactor(leftCountHitted, height);
            var rightEvenessFactor = CalculateEvennessFactor(rightCountHitted, height);

            evennessFactors.Add(new EvennessFactor(Side.Top, topEvenessFactor));
            evennessFactors.Add(new EvennessFactor(Side.Bottom, bottomEvenessFactor));
            evennessFactors.Add(new EvennessFactor(Side.Left, leftEvenessFactor));
            evennessFactors.Add(new EvennessFactor(Side.Right, rightEvenessFactor));

            return evennessFactors;
        }

        public static double GetDefaultEpsilon(int ballsCount)
        {
            return 1 / (double)ballsCount;
        }

        public bool IsEnd()
        {
            var evennessFactors = CalculateEvennessFactor();
            var isEnd = false;

            if(evennessFactors.Max(x => x.EvennessFactorValue) > epsilon)
            {
                var evennessFactorsMin = evennessFactors.Min(x => x.EvennessFactorValue);
                var evennessFactorsMax = evennessFactors.Max(x => x.EvennessFactorValue);

                isEnd = EqualTo(evennessFactorsMin, evennessFactorsMax, epsilon);
            }

            return isEnd;
        }
    }
}
