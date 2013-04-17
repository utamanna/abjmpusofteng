using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using Database;

namespace TICSET
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        // Call this constructor to redirect user to the
        // registration form with the username already filled
        // in when username is not found at the login screen
        //public RegistrationWindow(string username)
        //{
        //    InitializeComponent();
        //    tb_username.Text = username;

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            bool isFirstNameFull = false, isLastNameFull = false,
                isUserNameFull = false, isPasswordFull = false;

            // Validate that First Name is filled
            if (!(string.IsNullOrEmpty(tb_first_name.Text)))
            {
                errorProvider1.Clear();
                isFirstNameFull = true;
            }
            else
            {
                errorProvider1.SetError(tb_first_name, " Please enter your first name.");
            }

            // Validate that Last Name is filled
            if (!(string.IsNullOrEmpty(tb_last_name.Text)))
            {
                errorProvider2.Clear();
                isLastNameFull = true;
            }
            else
            {
                errorProvider2.SetError(tb_last_name, " Please enter your last name.");
            }

            // Validate that Username is filled
            if (!(string.IsNullOrEmpty(tb_username.Text)))
            {
                errorProvider3.Clear();
                isUserNameFull = true;
            }
            else
            {
                errorProvider3.SetError(tb_username, " Please enter a username.");
            }

            // Validate that Password is filled
            if (!(string.IsNullOrEmpty(tb_password.Text)))
            {
                errorProvider4.Clear();
                isPasswordFull = true;
            }
            else
            {
                errorProvider4.SetError(tb_password, " Please enter a password");
            }

            if (isFirstNameFull && isLastNameFull && isUserNameFull && isPasswordFull)
            {
                DatabaseHelper myHelper = new DatabaseHelper();
                if (myHelper.insertUserinStatisticTable(tb_username.Text) && myHelper.insertUserinUserTable(tb_first_name.Text, tb_last_name.Text, tb_username.Text, tb_password.Text))
                {
                    LoginWindow loginWindow = new LoginWindow();
                    this.Visible = false;
                    loginWindow.ShowDialog();
                    myHelper.Close();
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Visible = false;
            loginWindow.ShowDialog();
        }

        private void RegistrationWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
