using Common;

namespace DiffusionWinFormsApp
{
    public class DiffusionBall : BilliardBall
    {
        public Color Color { get; set; }

        public DiffusionBall(Color color, int borderLeftX, int borderRightX, int borderX, int borderY) : base(borderX, borderY)
        {
            diameter = 10;

            var x = random.Next(borderLeftX + diameter, borderRightX - diameter);
            var y = random.Next(diameter, borderY - diameter);

            centerPoint.X = x;
            centerPoint.Y = y;

            this.color = color;
            Color = color;
        }
    }
}