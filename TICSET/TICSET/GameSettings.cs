using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TICSET
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        public GameSettings(string player)
        {

            InitializeComponent();
            if (lbl_player_one.Text == player)
            {
               
                lbl_player_two.Text = player;

            }
            else
                lbl_player_one.Text = player;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            this.Visible = false;
            game.Show();
            
        }

        private void lbl_player_two_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            this.Visible = false;
            login.Show();
        }
    }
}
