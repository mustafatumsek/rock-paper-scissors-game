namespace rockPaperScissors
{
    partial class mainMenu
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
            label1 = new Label();
            btnPlay = new Button();
            btnQuit = new Button();
            btnHowTo = new Button();
            cbRounds = new ComboBox();
            btnStart = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 36F);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(776, 71);
            label1.TabIndex = 0;
            label1.Text = "ROCK PAPER SCISSORS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            btnPlay.BackgroundImage = Properties.Resources.button2;
            btnPlay.ForeColor = Color.Chocolate;
            btnPlay.Location = new Point(321, 203);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(169, 53);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackgroundImage = Properties.Resources.button1;
            btnQuit.ForeColor = Color.Chocolate;
            btnQuit.Location = new Point(342, 347);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(129, 37);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnHowTo
            // 
            btnHowTo.BackgroundImage = Properties.Resources.button1;
            btnHowTo.ForeColor = Color.Chocolate;
            btnHowTo.Location = new Point(342, 283);
            btnHowTo.Name = "btnHowTo";
            btnHowTo.Size = new Size(129, 37);
            btnHowTo.TabIndex = 3;
            btnHowTo.Text = "How to Play?";
            btnHowTo.UseVisualStyleBackColor = true;
            btnHowTo.Click += btnHowTo_Click;
            // 
            // cbRounds
            // 
            cbRounds.BackColor = Color.FromArgb(108, 54, 10);
            cbRounds.FormattingEnabled = true;
            cbRounds.Items.AddRange(new object[] { "3", "5", "7", "9", "Endless Mode" });
            cbRounds.Location = new Point(342, 288);
            cbRounds.Name = "cbRounds";
            cbRounds.Size = new Size(129, 28);
            cbRounds.TabIndex = 4;
            cbRounds.Text = "Rounds";
            cbRounds.Visible = false;
            cbRounds.SelectedIndexChanged += cbRounds_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = Properties.Resources.button2;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Enabled = false;
            btnStart.ForeColor = Color.Chocolate;
            btnStart.Location = new Point(321, 203);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(169, 53);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Visible = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = Properties.Resources.button1;
            btnCancel.ForeColor = Color.Chocolate;
            btnCancel.Location = new Point(342, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 37);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(cbRounds);
            Controls.Add(btnHowTo);
            Controls.Add(btnQuit);
            Controls.Add(btnPlay);
            Controls.Add(label1);
            Name = "mainMenu";
            Text = "Rock Paper Scissors Game";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnPlay;
        private Button btnQuit;
        private Button btnHowTo;
        private ComboBox cbRounds;
        private Button btnStart;
        private Button btnCancel;
    }
}
