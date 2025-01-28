using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rockPaperScissors
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        int selectedAvatar, enemy;
        int selected,score,enemyScore, roundPlayed = 0;
        int win, loss, draw, win2, loss2, draw2 = 0;
        int roundNo = mainMenu.rounds;

        private void picAvatar1_Click(object sender, EventArgs e)   //avatar seçme ekranında 1. avatar seçilirse
        {
            selectedAvatar = 1;
            picAvatar1.Image = rockPaperScissors.Properties.Resources.avatar1Selected;
            picAvatar2.Image = rockPaperScissors.Properties.Resources.avatar2;
            picAvatar3.Image = rockPaperScissors.Properties.Resources.avatar3;
            picSelectedAvatar.Image = rockPaperScissors.Properties.Resources.avatar1;
            btnAvatar.Enabled = true;
        }

        private void picAvatar2_Click(object sender, EventArgs e)   //avatar seçme ekranında 2. avatar seçilirse
        {
            selectedAvatar = 2;
            picAvatar2.Image = rockPaperScissors.Properties.Resources.avatar2Selected;
            picAvatar1.Image = rockPaperScissors.Properties.Resources.avatar1;
            picAvatar3.Image = rockPaperScissors.Properties.Resources.avatar3;
            picSelectedAvatar.Image = rockPaperScissors.Properties.Resources.avatar2;
            btnAvatar.Enabled = true;
        }

        private void picAvatar3_Click(object sender, EventArgs e)   //avatar seçme ekranında 3. avatar seçilirse
        {
            selectedAvatar = 3;
            picAvatar3.Image = rockPaperScissors.Properties.Resources.avatar3Selected;
            picAvatar1.Image = rockPaperScissors.Properties.Resources.avatar1;
            picAvatar2.Image = rockPaperScissors.Properties.Resources.avatar2;
            picSelectedAvatar.Image = rockPaperScissors.Properties.Resources.avatar3;
            btnAvatar.Enabled = true;
        }

        private void btnAvatar_Click(object sender, EventArgs e)    //avatar seçme ekranında seçim butonu
        {
            panelAvatar.Visible = false;
            panelBack.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)        //sayaç ve ardından sonuç durumları
        {
            progressBar1.Value--;
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                Random random = new Random();
                enemy = random.Next(1, 4);

                if (enemy == 1)
                {
                    picEnemyAvatar.Image = rockPaperScissors.Properties.Resources.rock_icon;
                    if (selected == 1) { draw++; }
                    if (selected == 2) { win++; }
                    if (selected == 3) { loss++; }

                }
                if (enemy == 2)
                {
                    picEnemyAvatar.Image = rockPaperScissors.Properties.Resources.paper_icon;
                    if (selected == 1) { loss++; }
                    if (selected == 2) { draw++; }
                    if (selected == 3) { win++; }
                }
                if (enemy == 3)
                {
                    picEnemyAvatar.Image = rockPaperScissors.Properties.Resources.scissors_icon1;
                    if (selected == 1) { win++; }
                    if (selected == 2) { loss++; }
                    if (selected == 3) { draw++; }
                }
                if (selected == 0) { MessageBox.Show("Please select a weapon.","Warning"); }    //seçim yapılmazsa
                if (win != win2) { score++; lblResult.Text = ("WIN"); lblResult.ForeColor = Color.Green; lblResult.Visible = true; roundPlayed++; } //kazanılırsa
                if (loss != loss2) { enemyScore++; lblResult.Text = ("LOSE"); lblResult.ForeColor = Color.Red; lblResult.Visible = true; roundPlayed++; }   //kaybedilirse
                if (draw != draw2) { lblResult.Text = ("DRAW"); lblResult.ForeColor = Color.Gray; lblResult.Visible = true; }   //berabere kalınırsa
                timer1.Stop();
                btnStart.Visible = true;
                lblScoreBoard.Text = score + " - " + enemyScore;
                win2 = win;
                loss2 = loss;
                draw2 = draw;
                if (roundPlayed == roundNo) //seçilen round sayısına ulaşılırsa
                {
                    if (win > loss)     //oyun bittiğinde kazanılırsa
                    { 
                        if (MessageBox.Show("Congratulations! You won. Do you want to continue in endless mode?", "VICTORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            roundNo = 99999;
                        }
                        else { this.Close(); mainMenu mainMenu = new mainMenu(); mainMenu.Show(); }
                    }
                    if (loss > win) //oyun bittiğinde kaybedilirse
                    {
                        if (MessageBox.Show("You lost. Good luck next time. Do you want to continue in endless mode?", "VICTORY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            roundNo = 99999;
                        }
                        else { this.Close(); mainMenu mainMenu = new mainMenu(); mainMenu.Show();  }
                    }
                }
            }
        }

        private void btnRock_Click(object sender, EventArgs e)  //taş
        {
            selected = 1;
            btnRock.BackgroundImage = rockPaperScissors.Properties.Resources.rockSelecteed;
            btnPaper.BackgroundImage = rockPaperScissors.Properties.Resources.paper_icon;
            btnScissors.BackgroundImage = rockPaperScissors.Properties.Resources.scissors_icon1;
        }

        private void btnPaper_Click(object sender, EventArgs e) //kağıt
        {
            selected = 2;
            btnPaper.BackgroundImage = rockPaperScissors.Properties.Resources.paperSelected;
            btnRock.BackgroundImage = rockPaperScissors.Properties.Resources.rock_icon;
            btnScissors.BackgroundImage = rockPaperScissors.Properties.Resources.scissors_icon1;
        }

        private void btnScissors_Click(object sender, EventArgs e)  //makas
        {
            selected = 3;
            btnScissors.BackgroundImage = rockPaperScissors.Properties.Resources.scissorsSelected;
            btnRock.BackgroundImage = rockPaperScissors.Properties.Resources.rock_icon;
            btnPaper.BackgroundImage = rockPaperScissors.Properties.Resources.paper_icon;
        }

        private void btnStart_Click(object sender, EventArgs e) //sayacı başlatma
        {
            btnStart.Visible = false;
            picEnemyAvatar.Image = rockPaperScissors.Properties.Resources.avatarEnemy;
            btnRock.BackgroundImage = rockPaperScissors.Properties.Resources.rock_icon;
            btnPaper.BackgroundImage = rockPaperScissors.Properties.Resources.paper_icon;
            btnScissors.BackgroundImage = rockPaperScissors.Properties.Resources.scissors_icon1;
            selected = 0;
            progressBar1.Value = 100;
            timer1.Start();
            lblResult.Visible = false;
        }
    }
}
