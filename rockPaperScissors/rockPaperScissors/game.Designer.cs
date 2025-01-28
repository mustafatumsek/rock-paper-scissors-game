namespace rockPaperScissors
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            panelAvatar = new Panel();
            btnAvatar = new Button();
            picAvatar3 = new PictureBox();
            picAvatar1 = new PictureBox();
            picAvatar2 = new PictureBox();
            lblAvatar = new Label();
            picSelectedAvatar = new PictureBox();
            picEnemyAvatar = new PictureBox();
            lblYou = new Label();
            lblRival = new Label();
            progressBar1 = new ProgressBar();
            lblScoreBoard = new Label();
            btnPaper = new Button();
            btnRock = new Button();
            btnScissors = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            lblResult = new Label();
            panelBack = new Panel();
            panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSelectedAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyAvatar).BeginInit();
            panelBack.SuspendLayout();
            SuspendLayout();
            // 
            // panelAvatar
            // 
            panelAvatar.BackColor = Color.LightGray;
            panelAvatar.Controls.Add(btnAvatar);
            panelAvatar.Controls.Add(picAvatar3);
            panelAvatar.Controls.Add(picAvatar1);
            panelAvatar.Controls.Add(picAvatar2);
            panelAvatar.Controls.Add(lblAvatar);
            panelAvatar.Location = new Point(142, 62);
            panelAvatar.Name = "panelAvatar";
            panelAvatar.Size = new Size(529, 299);
            panelAvatar.TabIndex = 0;
            // 
            // btnAvatar
            // 
            btnAvatar.Enabled = false;
            btnAvatar.Location = new Point(218, 254);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.Size = new Size(94, 29);
            btnAvatar.TabIndex = 4;
            btnAvatar.Text = "Done";
            btnAvatar.UseVisualStyleBackColor = true;
            btnAvatar.Click += btnAvatar_Click;
            // 
            // picAvatar3
            // 
            picAvatar3.BorderStyle = BorderStyle.Fixed3D;
            picAvatar3.Image = Properties.Resources.avatar3;
            picAvatar3.Location = new Point(356, 72);
            picAvatar3.Name = "picAvatar3";
            picAvatar3.Size = new Size(148, 164);
            picAvatar3.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar3.TabIndex = 3;
            picAvatar3.TabStop = false;
            picAvatar3.Click += picAvatar3_Click;
            // 
            // picAvatar1
            // 
            picAvatar1.BorderStyle = BorderStyle.Fixed3D;
            picAvatar1.Image = Properties.Resources.avatar1;
            picAvatar1.Location = new Point(26, 72);
            picAvatar1.Name = "picAvatar1";
            picAvatar1.Size = new Size(148, 164);
            picAvatar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar1.TabIndex = 2;
            picAvatar1.TabStop = false;
            picAvatar1.Click += picAvatar1_Click;
            // 
            // picAvatar2
            // 
            picAvatar2.BorderStyle = BorderStyle.Fixed3D;
            picAvatar2.Image = Properties.Resources.avatar2;
            picAvatar2.Location = new Point(191, 72);
            picAvatar2.Name = "picAvatar2";
            picAvatar2.Size = new Size(148, 164);
            picAvatar2.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar2.TabIndex = 1;
            picAvatar2.TabStop = false;
            picAvatar2.Click += picAvatar2_Click;
            // 
            // lblAvatar
            // 
            lblAvatar.Font = new Font("Segoe UI", 15F);
            lblAvatar.Location = new Point(3, 15);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(523, 47);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "Choose your avatar.";
            lblAvatar.TextAlign = ContentAlignment.TopCenter;
            // 
            // picSelectedAvatar
            // 
            picSelectedAvatar.BackColor = Color.Transparent;
            picSelectedAvatar.BorderStyle = BorderStyle.Fixed3D;
            picSelectedAvatar.Image = Properties.Resources.avatarBlack;
            picSelectedAvatar.Location = new Point(110, 43);
            picSelectedAvatar.Name = "picSelectedAvatar";
            picSelectedAvatar.Size = new Size(148, 164);
            picSelectedAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picSelectedAvatar.TabIndex = 5;
            picSelectedAvatar.TabStop = false;
            // 
            // picEnemyAvatar
            // 
            picEnemyAvatar.BackColor = Color.Transparent;
            picEnemyAvatar.BorderStyle = BorderStyle.Fixed3D;
            picEnemyAvatar.Image = Properties.Resources.avatarEnemy;
            picEnemyAvatar.Location = new Point(535, 43);
            picEnemyAvatar.Name = "picEnemyAvatar";
            picEnemyAvatar.Size = new Size(148, 164);
            picEnemyAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemyAvatar.TabIndex = 6;
            picEnemyAvatar.TabStop = false;
            // 
            // lblYou
            // 
            lblYou.AutoSize = true;
            lblYou.BackColor = Color.Transparent;
            lblYou.Font = new Font("Segoe UI", 13F);
            lblYou.Location = new Point(160, 210);
            lblYou.Name = "lblYou";
            lblYou.Size = new Size(48, 30);
            lblYou.TabIndex = 7;
            lblYou.Text = "You";
            // 
            // lblRival
            // 
            lblRival.AutoSize = true;
            lblRival.BackColor = Color.Transparent;
            lblRival.Font = new Font("Segoe UI", 13F);
            lblRival.Location = new Point(580, 210);
            lblRival.Name = "lblRival";
            lblRival.Size = new Size(58, 30);
            lblRival.TabIndex = 8;
            lblRival.Text = "Rival";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.MediumSeaGreen;
            progressBar1.Location = new Point(264, 257);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(265, 29);
            progressBar1.TabIndex = 9;
            progressBar1.Value = 100;
            // 
            // lblScoreBoard
            // 
            lblScoreBoard.BackColor = Color.Transparent;
            lblScoreBoard.Font = new Font("Segoe UI", 35F);
            lblScoreBoard.Location = new Point(264, 109);
            lblScoreBoard.Name = "lblScoreBoard";
            lblScoreBoard.Size = new Size(265, 98);
            lblScoreBoard.TabIndex = 10;
            lblScoreBoard.Text = "0 - 0";
            lblScoreBoard.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPaper
            // 
            btnPaper.BackgroundImage = Properties.Resources.paper_icon;
            btnPaper.BackgroundImageLayout = ImageLayout.Stretch;
            btnPaper.Location = new Point(343, 322);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(100, 100);
            btnPaper.TabIndex = 11;
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnRock
            // 
            btnRock.BackgroundImage = Properties.Resources.rock_icon;
            btnRock.BackgroundImageLayout = ImageLayout.Stretch;
            btnRock.ImageAlign = ContentAlignment.TopRight;
            btnRock.Location = new Point(217, 321);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(100, 100);
            btnRock.TabIndex = 12;
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnScissors
            // 
            btnScissors.BackgroundImage = Properties.Resources.scissors_icon1;
            btnScissors.BackgroundImageLayout = ImageLayout.Stretch;
            btnScissors.Location = new Point(469, 321);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(100, 100);
            btnScissors.TabIndex = 13;
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // timer1
            // 
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(343, 214);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 29);
            btnStart.TabIndex = 14;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResult.Location = new Point(264, 43);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(265, 78);
            lblResult.TabIndex = 15;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Visible = false;
            // 
            // panelBack
            // 
            panelBack.BackgroundImage = Properties.Resources.board;
            panelBack.Controls.Add(panelAvatar);
            panelBack.Location = new Point(12, 12);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(776, 426);
            panelBack.TabIndex = 16;
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBack);
            Controls.Add(lblResult);
            Controls.Add(btnStart);
            Controls.Add(btnScissors);
            Controls.Add(btnRock);
            Controls.Add(btnPaper);
            Controls.Add(lblScoreBoard);
            Controls.Add(progressBar1);
            Controls.Add(lblRival);
            Controls.Add(lblYou);
            Controls.Add(picEnemyAvatar);
            Controls.Add(picSelectedAvatar);
            Name = "game";
            Text = "Rock Paper Scissors";
            panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSelectedAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyAvatar).EndInit();
            panelBack.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAvatar;
        private Label lblAvatar;
        private PictureBox picAvatar3;
        private PictureBox picAvatar1;
        private PictureBox picAvatar2;
        private Button btnAvatar;
        private PictureBox picSelectedAvatar;
        private PictureBox picEnemyAvatar;
        private Label lblYou;
        private Label lblRival;
        private ProgressBar progressBar1;
        private Label lblScoreBoard;
        private Button btnPaper;
        private Button btnRock;
        private Button btnScissors;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Label lblResult;
        private Panel panelBack;
    }
}