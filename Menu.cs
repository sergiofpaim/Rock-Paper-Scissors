using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Main : Form
    {
        public Choice player1;
        public Choice player2;

        public Main()
        {
            InitializeComponent();

            Choice.Initialize();

            player1 = null;
            player2 = null;
        }
    
        private void player1_Pedra_CheckedChanged(object sender, EventArgs e)
        {
            player1 = Choice.Rock;
        }

        private void player1_Tesoura_CheckedChanged(object sender, EventArgs e)
        {
            player1 = Choice.Scissors;
        }
        private void player1_Papel_CheckedChanged(object sender, EventArgs e)
        {
            player1 = Choice.Paper;
        }

        private void player2_Pedra_CheckedChanged(object sender, EventArgs e)
        {
            player2 = Choice.Rock;
        }

        private void player2_Tesoura_CheckedChanged(object sender, EventArgs e)
        {
            player2 = Choice.Scissors;
        }

        private void player2_Papel_CheckedChanged(object sender, EventArgs e)
        {
            player2 = Choice.Paper;
        }

        private void PlayButton_Click_1(object sender, EventArgs e)
        {
            int match = player1.Match(player2);

            if (match == 0)
                MessageBox.Show("Tie");
            else if (match < 0)
                MessageBox.Show("Player 1 won!");
            else 
                MessageBox.Show("Player 2 won!");
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Rock Paper Scissors 1.0\n\nBy Sérgio Filho Paim (2022)\n\n" +
                            $"Source code: https://github.com/sergiofpaim/Rock-Paper-Scissors",
                            "About this game");
        }
    }
}
