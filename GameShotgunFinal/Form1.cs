using GameShotgunFinal.Classes;
using Microsoft.VisualBasic;

namespace GameShotgunFinal
{
    public partial class Form1 : Form
    {

        private HumanPlayer humanPlayer;
        private ComputerPlayer computerPlayer;
        private Game game;
        public Form1()
        {
            InitializeComponent();
            humanPlayer = new HumanPlayer("You");
            computerPlayer = new ComputerPlayer("Computer");
            game = new Game(humanPlayer, computerPlayer);
            buttonShotgun.Enabled = false;//disable the shotgun button

            labelHumanShots.Text = "Your shots: 0";
            labelComputerShots.Text = "Computer shots: 0";

        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            PlayMove("Shoot");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            PlayMove("Load");
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            PlayMove("Block");
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            PlayMove("Shotgun");
        }


        private void PlayMove(string move)
        {
            humanPlayer.SetMove(move);
            string computerMove = computerPlayer.MakeMove();
            string result = game.PlayRound(humanPlayer.MakeMove(), computerMove);
            labelResult.Text = result;



            if(result.Contains("won the game"))
            {
                MessageBox.Show(result, "Game over.");
                   
            }
            else
            {
                labelHumanShots.Text = "Your shots: " + humanPlayer.Ammo;
                labelComputerShots.Text = "Computer shots: " + computerPlayer.Ammo;

                buttonShotgun.Enabled = humanPlayer.Ammo >= 3;
            }

        
        }


    }
}
