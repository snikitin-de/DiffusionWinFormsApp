using Common;
using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace DiffusionWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<DiffusionBall> diffusionBalls = new List<DiffusionBall>();
        private Diffusion redBallsDiffusion;
        private Diffusion blueBallsDiffusion;
        private int redBallsCount = 500;
        private int blueBallsCount = 500;
        private double redBallsEpsilon = 1d;
        private double blueBallsEpsilon = 1d;
        private int renderInterval = 1;
        private int borderX;
        private int borderY;
        private bool isBallsStop = true;
        private bool isDifussionStart = false;

        public MainForm()
        {
            InitializeComponent();

            var renderTimer = new Timer();
            renderTimer.Interval = renderInterval;
            renderTimer.Enabled = true;
            renderTimer.Tick += (s, o) => { renderPictureBox.Refresh(); };
        }

        // Включение двойной буферизации для всех элементов управления
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020;
                return createParams;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            renderPictureBox.BackColor = GameColors.GameBackground;
            leftRedBallCountLabel.BackColor = GameColors.GameBackground;
            leftBlueBallCountLabel.BackColor = GameColors.GameBackground;
            rightRedBallCountLabel.BackColor = GameColors.GameBackground;
            rightBlueBallCountLabel.BackColor = GameColors.GameBackground;
            topRedBallCountLabel.BackColor = GameColors.GameBackground;
            topBlueBallCountLabel.BackColor = GameColors.GameBackground;
            bottomRedBallCountLabel.BackColor = GameColors.GameBackground;
            bottomBlueBallCountLabel.BackColor = GameColors.GameBackground;

            redBallsEpsilonNumericUpDown.DecimalPlaces = 4;
            redBallsEpsilonNumericUpDown.Increment = 0.0001m;
            redBallsEpsilonNumericUpDown.Value = Convert.ToDecimal(Diffusion.GetDefaultEpsilon(redBallsCount));
            blueBallsEpsilonNumericUpDown.DecimalPlaces = 4;
            blueBallsEpsilonNumericUpDown.Increment = 0.0001m;
            blueBallsEpsilonNumericUpDown.Value = Convert.ToDecimal(Diffusion.GetDefaultEpsilon(blueBallsCount));

            borderX = renderPictureBox.Width;
            borderY = renderPictureBox.Height;

            redBallsCountLabel.Text = blueBallsCount.ToString();
            redBallsCountTrackBar.Value = redBallsCount;

            blueBallsCountLabel.Text = blueBallsCount.ToString();
            blueBallsCountTrackBar.Value = blueBallsCount;

            CreateDiffusionBalls(redBallsCount, RedBall_OnHitted, Color.Red, 0, borderX / 2);
            CreateDiffusionBalls(blueBallsCount, BlueBall_OnHitted, Color.Blue, borderX / 2, borderX);
        }

        private void renderPictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ball in diffusionBalls)
            {
                ball.Draw(e.Graphics);
            }

            var formCenterX = ClientSize.Width / 2;
            var formHeight = ClientSize.Height;
            var pen = new Pen(Color.Black, 4);

            pen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawLine(pen, new Point(formCenterX, 0), new Point(formCenterX, formHeight));
        }

        private void RedBall_OnHitted(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftRedBallCountLabel.Text = (Convert.ToInt32(leftRedBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightRedBallCountLabel.Text = (Convert.ToInt32(rightRedBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topRedBallCountLabel.Text = (Convert.ToInt32(topRedBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomRedBallCountLabel.Text = (Convert.ToInt32(bottomRedBallCountLabel.Text) + 1).ToString();
                    break;
            }

            var topCountHitted = Convert.ToInt32(topRedBallCountLabel.Text);
            var bottomCountHitted = Convert.ToInt32(bottomRedBallCountLabel.Text);
            var leftCountHitted = Convert.ToInt32(leftRedBallCountLabel.Text);
            var rightCountHitted = Convert.ToInt32(rightRedBallCountLabel.Text);

            redBallsDiffusion = new Diffusion(topCountHitted, bottomCountHitted, leftCountHitted, rightCountHitted, borderX, borderY, redBallsEpsilon);
            var evennessFactors = redBallsDiffusion.CalculateEvennessFactor();

            redBallsEvennessFactorTopLabel.Text = "Распределение по верхней стенке: " + evennessFactors.First(x => x.Side == Side.Top).EvennessFactorValue.ToString();
            redBallsEvennessFactorBottomLabel.Text = "Распределение по нижней стенке: " + evennessFactors.First(x => x.Side == Side.Bottom).EvennessFactorValue.ToString();
            redBallsEvennessFactorLeftLabel.Text = "Распределение по левой стенке: " + evennessFactors.First(x => x.Side == Side.Left).EvennessFactorValue.ToString();
            redBallsEvennessFactorRightLabel.Text = "Распределение по правой стенке: " + evennessFactors.First(x => x.Side == Side.Right).EvennessFactorValue.ToString();

            if (redBallsDiffusion != null && redBallsDiffusion.IsEnd() && blueBallsDiffusion != null && blueBallsDiffusion.IsEnd())
            {
                foreach (var ball in diffusionBalls)
                {
                    ball.Stop();
                }

                MessageBox.Show("Диффузия завершена!", "Диффузия");
            }
        }

        private void BlueBall_OnHitted(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftBlueBallCountLabel.Text = (Convert.ToInt32(leftBlueBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightBlueBallCountLabel.Text = (Convert.ToInt32(rightBlueBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topBlueBallCountLabel.Text = (Convert.ToInt32(topBlueBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomBlueBallCountLabel.Text = (Convert.ToInt32(bottomBlueBallCountLabel.Text) + 1).ToString();
                    break;
            }

            var topCountHitted = Convert.ToInt32(topBlueBallCountLabel.Text);
            var bottomCountHitted = Convert.ToInt32(bottomBlueBallCountLabel.Text);
            var leftCountHitted = Convert.ToInt32(leftBlueBallCountLabel.Text);
            var rightCountHitted = Convert.ToInt32(rightBlueBallCountLabel.Text);
            blueBallsDiffusion = new Diffusion(topCountHitted, bottomCountHitted, leftCountHitted, rightCountHitted, borderX, borderY, blueBallsEpsilon);
            var evennessFactors = blueBallsDiffusion.CalculateEvennessFactor();

            blueBallsEvennessFactorTopLabel.Text = "Распределение по верхней стенке: " + evennessFactors.First(x => x.Side == Side.Top).EvennessFactorValue.ToString();
            blueBallsEvennessFactorBottomLabel.Text = "Распределение по нижней стенке: " + evennessFactors.First(x => x.Side == Side.Bottom).EvennessFactorValue.ToString();
            blueBallsEvennessFactorLeftLabel.Text = "Распределение по левой стенке: " + evennessFactors.First(x => x.Side == Side.Left).EvennessFactorValue.ToString();
            blueBallsEvennessFactorRightLabel.Text = "Распределение по правой стенке: " + evennessFactors.First(x => x.Side == Side.Right).EvennessFactorValue.ToString();

            if (redBallsDiffusion != null && redBallsDiffusion.IsEnd() && blueBallsDiffusion != null && blueBallsDiffusion.IsEnd())
            {
                foreach (var ball in diffusionBalls)
                {
                    ball.Stop();
                }

                MessageBox.Show("Диффузия завершена!", "Диффузия");
            }
        }

        private void renderPictureBox_Resize(object sender, EventArgs e)
        {
            borderX = renderPictureBox.Width;
            borderY = renderPictureBox.Height;

            foreach (var ball in diffusionBalls)
            {
                ball.UpdateBorders(borderX, borderY);
                ball.Stop();
            }

            diffusionBalls.Clear();

            CreateDiffusionBalls(redBallsCount, RedBall_OnHitted, Color.Red, 0, borderX / 2);
            CreateDiffusionBalls(blueBallsCount, BlueBall_OnHitted, Color.Blue, borderX / 2, borderX);

            isBallsStop = true;
        }

        private void renderPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDifussionStart)
            {
                blueBallsCountTrackBar.Enabled = false;
                redBallsCountTrackBar.Enabled = false;
                blueBallsEpsilonNumericUpDown.Enabled = false;
                redBallsEpsilonNumericUpDown.Enabled = false;

                isDifussionStart = true;
            }

            foreach (var ball in diffusionBalls)
            {
                if (isBallsStop)
                {
                    ball.Start();
                }
                else
                {
                    ball.Stop();
                }
            }

            isBallsStop = !isBallsStop;
        }

        private void redBallsCountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            redBallsCount = redBallsCountTrackBar.Value;
            redBallsEpsilon = Diffusion.GetDefaultEpsilon(redBallsCount);
            redBallsEpsilonNumericUpDown.Value = (decimal)redBallsEpsilon;
            redBallsEpsilonLabel.Text = "Погрешность: " + Math.Round(redBallsEpsilon, 4);

            redBallsCountLabel.Text = redBallsCount.ToString();
            diffusionBalls.RemoveAll(x => x.Color == Color.Red);

            CreateDiffusionBalls(redBallsCount, RedBall_OnHitted, Color.Red, 0, borderX / 2);
        }

        private void blueBallsCountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            blueBallsCount = blueBallsCountTrackBar.Value;
            blueBallsEpsilon = Diffusion.GetDefaultEpsilon(blueBallsCount);
            blueBallsEpsilonNumericUpDown.Value = (decimal)blueBallsEpsilon;
            blueBallsEpsilonLabel.Text = "Погрешность: " + Math.Round(blueBallsEpsilon, 4);

            blueBallsCountLabel.Text = blueBallsCount.ToString();
            diffusionBalls.RemoveAll(x => x.Color == Color.Blue);

            CreateDiffusionBalls(blueBallsCount, BlueBall_OnHitted, Color.Blue, borderX / 2, borderX);
        }

        private void redBallsEpsilonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            redBallsEpsilon = Convert.ToDouble(redBallsEpsilonNumericUpDown.Value);
            redBallsEpsilonLabel.Text = "Погрешность: " + Math.Round(redBallsEpsilon, 4);
        }

        private void blueBallsEpsilonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            blueBallsEpsilon = Convert.ToDouble(blueBallsEpsilonNumericUpDown.Value);
            blueBallsEpsilonLabel.Text = "Погрешность: " + Math.Round(blueBallsEpsilon, 4);
        }

        private void CreateDiffusionBalls(int ballsCount, EventHandler<HitEventArgs> ballOnHitted, Color color, int borderLeftX, int borderRightX)
        {
            for (var i = 0; i < ballsCount; i++)
            {
                var balls = new DiffusionBall(color, borderLeftX, borderRightX, borderX, borderY);
                diffusionBalls.Add(balls);
                balls.OnHitted += ballOnHitted;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            redBallsEvennessFactorTopLabel.Text = "Распределение по верхней стенке: 0";
            redBallsEvennessFactorBottomLabel.Text = "Распределение по нижней стенке: 0";
            redBallsEvennessFactorLeftLabel.Text = "Распределение по левой стенке: 0";
            redBallsEvennessFactorRightLabel.Text = "Распределение по правой стенке: 0";
            blueBallsEvennessFactorTopLabel.Text = "Распределение по верхней стенке: 0";
            blueBallsEvennessFactorBottomLabel.Text = "Распределение по нижней стенке: 0";
            blueBallsEvennessFactorLeftLabel.Text = "Распределение по левой стенке: 0";
            blueBallsEvennessFactorRightLabel.Text = "Распределение по правой стенке: 0";
            blueBallsEpsilonLabel.Text = "Погрешность: 0";

            topRedBallCountLabel.Text = "0";
            bottomRedBallCountLabel.Text = "0";
            leftRedBallCountLabel.Text = "0";
            rightRedBallCountLabel.Text = "0";
            topBlueBallCountLabel.Text = "0";
            bottomBlueBallCountLabel.Text = "0";
            leftBlueBallCountLabel.Text = "0";
            rightBlueBallCountLabel.Text = "0";

            blueBallsCountTrackBar.Enabled = true;
            redBallsCountTrackBar.Enabled = true;
            blueBallsEpsilonNumericUpDown.Enabled = true;
            redBallsEpsilonNumericUpDown.Enabled = true;
            isDifussionStart = false;

            foreach (var ball in diffusionBalls)
            {
                ball.Stop();
            }

            isBallsStop = true;

            diffusionBalls.Clear();

            CreateDiffusionBalls(redBallsCount, RedBall_OnHitted, Color.Red, 0, borderX / 2);
            CreateDiffusionBalls(blueBallsCount, BlueBall_OnHitted, Color.Blue, borderX / 2, borderX);
        }
    }
}