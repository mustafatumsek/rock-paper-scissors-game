namespace rockPaperScissors
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        public static int rounds;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnHowTo.Visible = false;
            btnPlay.Visible = false;
            btnQuit.Visible = false;
            btnStart.Visible = true;
            btnCancel.Visible = true;
            cbRounds.Visible = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnHowTo.Visible = true;
            btnPlay.Visible = true;
            btnQuit.Visible = true;
            btnStart.Visible = false;
            btnCancel.Visible = false;
            cbRounds.Visible = false;
            btnStart.Enabled = false;
            cbRounds.Text = "Rounds";
        }

        private void cbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose number of rounds. Select rock, paper or scissors. Rock beats scissors, scissors beat paper, and paper beats rock. Good luck and pay attention to the time.", "How to Play?");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbRounds.SelectedIndex == 4) { rounds = 9999999; }
            else { rounds = Convert.ToInt32(cbRounds.Text); }
            this.Hide();
            game game = new game();
            game.Show();
        }
    }
}
