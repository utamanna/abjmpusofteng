using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;

namespace TICSET
{
    public partial class LoginWindow : Form
    {
        // Variables
        string player_one, player_one_username;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void lbl_new_user_Click(object sender, EventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            this.Visible = false;
            registrationWindow.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool isUsernameFull = false, isPasswordFull = false;
<<<<<<< HEAD
            /*========================================
             *got frustrated, DB is not working for me
             *Delete Until: 
            *=========================================*/ 
=======
            //got frustrated, DB is not working for me
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
            if (tb_username.Text == "joseph")
            {
                player_one_username = "jpk";
                player_one = "Joseph";
                player_one += " " + "Kanter";
                this.Visible = false;
                GameSettings gameSettings = new GameSettings(player_one, player_one_username);
                gameSettings.Show();
            }
<<<<<<< HEAD
            /*==========================================HERE*/


=======
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
            // Validate that username is not empty
            if (!(string.IsNullOrEmpty(tb_username.Text)))
            {
                errorProvider1.Clear();
                isUsernameFull = true;
            }

            else
            {
                errorProvider1.SetError(tb_username, " Please provide a username.");
            }

            // Validate that password is not empty
            if (!(string.IsNullOrEmpty(tb_password.Text)))
            {
                errorProvider2.Clear();
                isPasswordFull = true;
            }
            else
            {
                errorProvider2.SetError(tb_password, " Please provide a password.");
            }

            if( isUsernameFull && isPasswordFull )
            {
                DatabaseHelper myHelper = new DatabaseHelper();
                if (myHelper.CheckLogin(tb_username.Text, tb_password.Text))
                {
                    
                    GameSettings gameSettings = new GameSettings(myHelper.getUsersFullName(tb_username.Text), tb_username.Text);
                    this.Visible = false;
                    gameSettings.Show();
                    myHelper.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }


        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
