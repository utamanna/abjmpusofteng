using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gamePlay;
using Database;

namespace TICSET
{
    public partial class Gameover : Form
    {
        string p1_username = "";
        string p2_username = "";
        
        DatabaseHelper myHelper;

        public Gameover()
        {
            InitializeComponent();
        }

        public Gameover(Player p1, Player p2, char who_won)
        {
            InitializeComponent();
            p1_username = p1.getID();
            p2_username = p2.getID();
            if (who_won == 'x' || who_won == 'X')
            {
                lbl_won.Text = p1_username + " Won!";
                lbl_lost.Text = p2_username + " Lost!";
            }
            if (who_won == 'o' || who_won == 'O')
            {
                lbl_won.Text = p2_username + " Won!";
                lbl_lost.Text = p1_username + " Lost!";
            }

            myHelper = new DatabaseHelper();
            string[] leaderboard_string = myHelper.Leaderboard();
            lbl_leaderboard_number.Text = leaderboard_string[0];
            lbl_leaderboard_username.Text = leaderboard_string[1];
            lbl_leaderboard_wins.Text = leaderboard_string[2];
            lbl_leaderboard_losses.Text = leaderboard_string[3];

        }

        private void lbl_leaderboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_gameover_exit_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

    }
}
