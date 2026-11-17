namespace ship
{
    public partial class BattleShip : System.Windows.Forms.Form
    {
      bool  cannonflying = false;
        int dx = -5;
        public BattleShip()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            timerCannonBall.Enabled = false;
            pictureBoxCannonBall.Visible = false;
            pictureBoxBoom.Visible = false;
        }

        void InitGame()
        {
            cannonflying = false;
            pictureBoxShip.Location = new Point(1150, 2);
            pictureBoxShip.Visible = true;
            timernum1.Enabled = true;
            pictureBoxCannon.Visible = true;
            pictureBoxBoom.Visible = false;

        }

        private void timernum1_Tick(object sender, EventArgs e)
        {
            pictureBoxShip.Location = new Point(pictureBoxShip.Location.X + dx, pictureBoxShip.Location.Y);
            if (pictureBoxShip.Location.X < 0 || pictureBoxShip.Location.X > Width - pictureBoxShip.Width - 10) dx = -dx;
        }

        double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((a.X + pictureBoxCannonBall.Width / 2) - (b.X + pictureBoxShip.Width / 2), 2) + Math.Pow((a.Y + pictureBoxCannonBall.Height / 2) - (b.Y + pictureBoxShip.Height / 2), 2));
        }
        private void timerCannonBall_Tick(object sender, EventArgs e)
        {
            pictureBoxCannonBall.Location = new Point(pictureBoxCannonBall.Location.X, pictureBoxCannonBall.Location.Y - 10);
            if (Distance(pictureBoxCannonBall.Location, pictureBoxShip.Location) < pictureBoxShip.Width / 2)
            {
                pictureBoxBoom.Location = pictureBoxShip.Location;
                pictureBoxBoom.Size = pictureBoxShip.Size;
                pictureBoxBoom.Visible = true;
                timerCannonBall.Enabled = false;
                timernum1.Enabled = false;

                pictureBoxShip.Visible = false;
                pictureBoxCannonBall.Visible = false;

                if (MessageBox.Show("Хотите еще сыграть?", "Цель поражена", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InitGame();
                }
                else
                {
                    Close();
                }
            }
            if (pictureBoxCannonBall.Location.Y < 0)
            {
                pictureBoxCannonBall.Visible = false;
                timerCannonBall.Enabled = false;
                cannonflying = false;

            }
        }

        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !cannonflying)
            {
                cannonflying = true;
                pictureBoxCannonBall.Location = new Point(pictureBoxCannon.Left + (pictureBoxCannon.Width - pictureBoxCannonBall.Width) / 2, pictureBoxCannon.Top - pictureBoxCannonBall.Height);
                pictureBoxCannonBall.Visible = true;
                timerCannonBall.Enabled = true;
            }
        }
       
    }
}
