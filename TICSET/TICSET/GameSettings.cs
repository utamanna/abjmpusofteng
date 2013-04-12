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
            lbl_player_one.Text = player;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            this.Visible = false;
            game.Show();
            
        }

        // ==============================
        // LOGIN FOR PLAYER TWO
        // ==============================
        private void lbl_player_two_Click(object sender, EventArgs e)
        {
            var login = new LoginWindowForPlayerTwo();
            var result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                string tmp = login.player_two_name;
                lbl_player_two.Text = tmp;
            }
        }
    }
}
