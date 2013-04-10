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
        public RegistrationWindow(string username)
        {
            InitializeComponent();
            tb_username.Text = username;

        }

        private SqlCeConnection connection;

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
                // Add the user to the database
                try
                {
                    string connectionString = @"Data Source=C:\Users\bryan nafegar\Desktop\Users.sdf";
                    using (SqlCeConnection connection = new SqlCeConnection(connectionString))
                    using (SqlCeCommand command = new SqlCeCommand("INSERT INTO [user] (username, password, first_name, last_name) VALUES (@username, @password, @first_name, @last_name)", connection))
                    {
                       // command.CommandText = "INSERT INTO user (username, password, first_name, last_name) VALUES (@username, @password, @first_name, @last_name)";

                        command.Parameters.AddWithValue("@username", tb_username.Text);
                        command.Parameters.AddWithValue("@password", tb_password.Text);
                        command.Parameters.AddWithValue("@first_name", tb_first_name.Text);
                        command.Parameters.AddWithValue("@last_name", tb_last_name.Text);

                        connection.Open();
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                LoginWindow loginWindow = new LoginWindow();
                this.Visible = false;
                loginWindow.ShowDialog();
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
