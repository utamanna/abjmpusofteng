using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gamePlay;
using AI;
namespace TICSET
{
    public partial class GameSettings : Form
    {
        // Variables for global settings
        Settings settings;
        Player player_one;
        Player player_two;
        char whoGoesFirst;
        int difficulty = 3;

        // Instance varialbes
        private string p_one_username, p_two_username;
        private char x = 'X', o = 'O';
        private bool player_one_boolean = true;
        private bool player_two_boolean = false;
        private char combo_box_selection;

        public GameSettings()
        {
            InitializeComponent();
        }

        public GameSettings(string player, string player_username)
        {
            InitializeComponent();
            lbl_player_one.Text = player;
            p_one_username = player_username;
            player_one = new HumanPlayer(player_username, x);
            player_two = new computerPlayer(o);
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
                // Assign player 2 name and usernames
                string tmp = login.player_two_name;
                string tmp1 = login.player_two_username;
                lbl_player_two.Text = tmp;
                p_two_username = tmp1;
                player_two_boolean = true;

                // Make a player 2 object
                player_two = new Player(p_two_username, o, player_two_boolean);

                //===============================
                // HIDE COMPUTER RELATED SETTINGS
                //===============================
                panel_AI_difficulty.Enabled = false;
                if(!(lbl_player_two.Text == "computer" || lbl_player_two.Text =="Computer"))
                image_keyboard.Visible = true;
            }
        }

        private void image_keyboard_Click(object sender, EventArgs e)
        {
            lbl_player_two.Text = "Computer";
            image_keyboard.Visible = false;
            player_two_boolean = false;
            player_two = new computerPlayer(o);
        }



        // =======================================
        // GET ALL THE SETTINGS AND MAKE A 
        // SETTINGS OBJECT AND PASS IT TO game.cs
        // =======================================
        private void start_game_Click(object sender, EventArgs e)
        {
            int comboSelection = FirstCombo.SelectedIndex;

            switch (comboSelection)
            {
                case 0:
                    whoGoesFirst = x;
                    break;
                case 1:
                    whoGoesFirst = o;
                    break;
            }

            if (lbl_player_two.Text == "Computer" || lbl_player_two.Text == "computer")
            {
                if (easyradiobutton.Checked)
                {
                    difficulty = 0;
                }
                else
                {
                    difficulty = 1;
                }
            }

            // =======================
            // MAKE A SETTINGS OBJECT
            // =======================
            settings = new Settings(player_one, player_two, whoGoesFirst, difficulty);
            this.Visible = false;

            Game game = new Game(settings);

            // Joe, You can instantiate a game class here and start
            // a Form1 object inside your class here....

        }
    }
}
