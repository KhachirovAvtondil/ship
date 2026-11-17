namespace ship
{
    partial class BattleShip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleShip));
            pictureBoxCannon = new PictureBox();
            pictureBoxCannonBall = new PictureBox();
            timernum1 = new System.Windows.Forms.Timer(components);
            timerCannonBall = new System.Windows.Forms.Timer(components);
            pictureBoxBoom = new PictureBox();
            pictureBoxShip = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCannon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCannonBall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCannon
            // 
            pictureBoxCannon.Anchor = AnchorStyles.Bottom;
            pictureBoxCannon.BackColor = Color.Transparent;
            pictureBoxCannon.Image = (Image)resources.GetObject("pictureBoxCannon.Image");
            pictureBoxCannon.Location = new Point(331, 409);
            pictureBoxCannon.Name = "pictureBoxCannon";
            pictureBoxCannon.Size = new Size(115, 106);
            pictureBoxCannon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCannon.TabIndex = 1;
            pictureBoxCannon.TabStop = false;
            // 
            // pictureBoxCannonBall
            // 
            pictureBoxCannonBall.BackColor = Color.Transparent;
            pictureBoxCannonBall.BackgroundImageLayout = ImageLayout.None;
            pictureBoxCannonBall.Image = Properties.Resources.pngtree_cannonball_isolated_on_transparent_background_png_image_14458104;
            pictureBoxCannonBall.Location = new Point(368, 361);
            pictureBoxCannonBall.Name = "pictureBoxCannonBall";
            pictureBoxCannonBall.Size = new Size(40, 42);
            pictureBoxCannonBall.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCannonBall.TabIndex = 2;
            pictureBoxCannonBall.TabStop = false;
            // 
            // timernum1
            // 
            timernum1.Enabled = true;
            timernum1.Interval = 2;
            timernum1.Tick += timernum1_Tick;
            // 
            // timerCannonBall
            // 
            timerCannonBall.Enabled = true;
            timerCannonBall.Interval = 1;
            timerCannonBall.Tick += timerCannonBall_Tick;
            // 
            // pictureBoxBoom
            // 
            pictureBoxBoom.BackColor = Color.Transparent;
            pictureBoxBoom.Image = Properties.Resources.vecteezy_fiery_explosions_on_a_transparent_background_showcase_55324738;
            pictureBoxBoom.InitialImage = (Image)resources.GetObject("pictureBoxBoom.InitialImage");
            pictureBoxBoom.Location = new Point(1088, 558);
            pictureBoxBoom.Name = "pictureBoxBoom";
            pictureBoxBoom.Size = new Size(79, 87);
            pictureBoxBoom.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBoom.TabIndex = 3;
            pictureBoxBoom.TabStop = false;
            // 
            // pictureBoxShip
            // 
            pictureBoxShip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxShip.BackColor = Color.Transparent;
            pictureBoxShip.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxShip.Image = (Image)resources.GetObject("pictureBoxShip.Image");
            pictureBoxShip.InitialImage = (Image)resources.GetObject("pictureBoxShip.InitialImage");
            pictureBoxShip.Location = new Point(667, 1);
            pictureBoxShip.Name = "pictureBoxShip";
            pictureBoxShip.Size = new Size(121, 103);
            pictureBoxShip.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShip.TabIndex = 0;
            pictureBoxShip.TabStop = false;
            // 
            // BattleShip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blue_sea_background_1110_591;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 522);
            Controls.Add(pictureBoxBoom);
            Controls.Add(pictureBoxCannonBall);
            Controls.Add(pictureBoxCannon);
            Controls.Add(pictureBoxShip);
            Name = "BattleShip";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FormGame_Load;
            KeyUp += FormGame_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCannon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCannonBall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxCannon;
        private PictureBox pictureBoxCannonBall;
        private System.Windows.Forms.Timer timernum1;
        private System.Windows.Forms.Timer timerCannonBall;
        private PictureBox pictureBoxBoom;
        private PictureBox pictureBoxShip;
    }
}
