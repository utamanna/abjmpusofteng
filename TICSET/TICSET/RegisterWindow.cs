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
    public partial class RegisterWindow : Form
    {

        // Variable for the login window form
        private LoginWindow loginWindow;

        // Variables to get the data from the form
        private string username, password, first_name, last_name;
        public RegisterWindow()
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;  
        }

        private void userInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void RegisterWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.usersDataSet.UserInfo);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Validate to make sure all the fields are filled
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                // To-do, add user to the database
                MessageBox.Show("All controls are valid!");
                // Hide the registration form
                this.Visible = false;
                // Open the login form
                loginWindow = new LoginWindow();
                loginWindow.Show();
            }
            else
            {

            }
            
            
        }

        private void usernameTextBox_Validating(Object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.usernameTextBox.Text))
            {
                // Fails validation, display error message
                cancel = true;
                this.errorProvider1.SetError(usernameTextBox, "Please provide a username");
            }
            e.Cancel = cancel;
        }
        
    }
}
