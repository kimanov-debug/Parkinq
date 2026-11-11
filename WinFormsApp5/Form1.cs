using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parkinq
{
    public partial class Form1 : Form
    {
        private Panel[] spots = Array.Empty<Panel>();
        private readonly Random rnd = new Random();

        private const int MaxTime = 30;
        private const int Step = 6;

        private int score;
        private int timeLeft;
        private int targetIndex;
        private bool gameOver = true;

        private Color spotColor;
        private readonly Color targetColor = Color.FromArgb(46, 94, 62);
        private readonly Color successColor = Color.FromArgb(144, 238, 144);
        private readonly Color errorColor = Color.FromArgb(255, 107, 107);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            spots = new Panel[] { pnlSpot1, pnlSpot2, pnlSpot3, pnlSpot4, pnlSpot5 };
            spotColor = pnlSpot1.BackColor;

            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            timer1.Tick += timer1_Tick;

            StartNewGame();
        }

        // ---------- Oyunun başlaması / sıfırlanması ----------

        private void StartNewGame()
        {
            score = 0;
            timeLeft = MaxTime;
            gameOver = false;

            lblMessage.Text = "";
            lblMessage.ForeColor = successColor;

            ResetCarPosition();
            pnlCar.Visible = true;

            NewTarget();
            UpdateLabels();

            timer1.Stop();
            timer1.Start();
        }

        private void ResetCarPosition()
        {
            pnlCar.Parent = this;
            pnlCar.Location = new Point(
                tlpParking.Left + (tlpParking.Width - pnlCar.Width) / 2,
                tlpParking.Bottom + 30);
            pnlCar.BringToFront();
        }

        private void NewTarget()
        {
            targetIndex = rnd.Next(spots.Length);
            UpdateSpotColors();
        }

        private void UpdateSpotColors()
        {
            for (int i = 0; i < spots.Length; i++)
            {
                spots[i].BackColor = (!gameOver && i == targetIndex) ? targetColor : spotColor;
            }
        }

        private void UpdateLabels()
        {
            lblScore.Text = "Xal: " + score;
            lblTime.Text = "Vaxt: " + timeLeft + " san";
        }

        // ---------- Hərəkət ----------

        private void MoveCar(int dx, int dy)
        {
            int x = pnlCar.Left + dx;
            int y = pnlCar.Top + dy;

            int minY = pnlTop.Bottom;
            int maxX = ClientSize.Width - pnlCar.Width;
            int maxY = ClientSize.Height - pnlCar.Height;

            x = Math.Max(0, Math.Min(x, maxX));
            y = Math.Max(minY, Math.Min(y, maxY));

            pnlCar.Location = new Point(x, y);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (gameOver) return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    MoveCar(0, -Step);
                    break;
                case Keys.Down:
                    MoveCar(0, Step);
                    break;
                case Keys.Left:
                    MoveCar(-Step, 0);
                    break;
                case Keys.Right:
                    MoveCar(Step, 0);
                    break;
                case Keys.Space:
                    ParkCar();
                    break;
                default:
                    return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        // ---------- Park yoxlaması ----------

        private Rectangle SpotBounds(Panel spot)
        {
            Control? parent = spot.Parent;
            if (parent == null) return Rectangle.Empty;

            return new Rectangle(
                parent.Left + spot.Left,
                parent.Top + spot.Top,
                spot.Width,
                spot.Height);
        }

        private void ParkCar()
        {
            Rectangle car = pnlCar.Bounds;
            Rectangle target = SpotBounds(spots[targetIndex]);

            if (target.Contains(car))
            {
                score++;
                UpdateLabels();
                EndGame(true);
            }
            else
            {
                if (score > 0) score--;
                lblMessage.ForeColor = errorColor;
                lblMessage.Text = "Səhv yer! -1";
                UpdateLabels();
            }
        }

        private void EndGame(bool won)
        {
            gameOver = true;
            timer1.Stop();
            UpdateSpotColors();

            if (won)
            {
                lblMessage.ForeColor = successColor;
                lblMessage.Text = "Qalibiyyət! Yekun xal: " + score;
            }
        }

        // ---------- Taymer ----------

        private void timer1_Tick(object? sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0)
            {
                score = 0;
                timeLeft = MaxTime;
                lblMessage.ForeColor = errorColor;
                lblMessage.Text = "Vaxt bitdi! Oyun sıfırlandı";
                ResetCarPosition();
                NewTarget();
            }

            UpdateLabels();
        }

        private void btnNewGame_Click(object? sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}