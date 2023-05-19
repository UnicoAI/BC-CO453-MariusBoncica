using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {


        int rounds = 3;
        int timerPerRound = 6;

        bool gameover = false;
        private static readonly string[] value = { "ROCK", "PAPER", "SCISSORS", "PAPER", "SCISSORS", "ROCK" };
        readonly string[] CPUchoiceList = value;

        int randomNumber = 0;
        readonly Random rnd = new();

        string CPUchoice;

        string playerChoice;

        int playerwins;
        int AIwins;


        public Form1()
        {
            InitializeComponent();
            countDownTimer.Enabled = true;
            playerChoice = "none";
            txtTime.Text = "5";
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = RockPapperScissors.Properties.Resources.rock;
            playerChoice = "ROCK";
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = RockPapperScissors.Properties.Resources.paper;
            playerChoice = "PAPER";
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = RockPapperScissors.Properties.Resources.scissors;
            playerChoice = "SCISSORS";
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            txtTime.Text = timerPerRound.ToString();
            roundsText.Text = "Rounds: " + rounds;

            if (timerPerRound < 1)
            {
                countDownTimer.Enabled = false;
                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUchoice = CPUchoiceList[randomNumber];

                switch (CPUchoice)
                {
                    case "ROCK":
                        picCPU.Image = RockPapperScissors.Properties.Resources.rock;
                        break;
                    case "PAPER":
                        picCPU.Image = RockPapperScissors.Properties.Resources.paper;
                        break;
                    case "SCISSORS":
                        picCPU.Image = RockPapperScissors.Properties.Resources.scissors;
                        break;
                }


                if (rounds > 0)
                {
                    CheckGame();
                }
                else
                {
                    if (playerwins > AIwins)
                    {
                        MessageBox.Show("Player Wins!");
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                    }

                    gameover = true;
                }


            }
        }


        private void CheckGame()
        {

            // AI and player win rules

            if (playerChoice == "ROCK" && CPUchoice == "PAPER")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("Computer Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "SCISSORS" && CPUchoice == "ROCK")
            {
                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("Computer Wins, Rock Breaks Scissors");
            }
            else if (playerChoice == "PAPER" && CPUchoice == "SCISSORS")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("Computer Wins, Scissor cuts paper");

            }
            else if (playerChoice == "ROCK" && CPUchoice == "SCISSORS")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Rock Breaks Scissors");

            }
            else if (playerChoice == "PAPER" && CPUchoice == "ROCK")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "SCISSORS" && CPUchoice == "PAPER")
            {
                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Scissor cuts paper");

            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Make your Choice");
            }
            else
            {
                MessageBox.Show("Draw");

            }

            StartNextRound();
        }

        public void StartNextRound()
        {

            if (gameover)
            {



                return;
            }

            txtMessage.Text = "Player: " + playerwins + " - " + "Computer: " + AIwins;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = RockPapperScissors.Properties.Resources.qq;
            picCPU.Image = RockPapperScissors.Properties.Resources.qq;
        }

        private void RestartGame(object sender, EventArgs e)
        {
            playerwins = 0;
            AIwins = 0;
            rounds = 3;
            txtMessage.Text = "Player: " + playerwins + " - " + "Computer: " + AIwins;

            playerChoice = "none";
            txtTime.Text = "5";

            countDownTimer.Enabled = true;

            picPlayer.Image = RockPapperScissors.Properties.Resources.qq;
            picCPU.Image = RockPapperScissors.Properties.Resources.qq;

            gameover = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PicCPU_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtMessage_Click(object sender, EventArgs e)
        {

        }

        private void RoundsText_Click(object sender, EventArgs e)
        {

        }
    }
}
