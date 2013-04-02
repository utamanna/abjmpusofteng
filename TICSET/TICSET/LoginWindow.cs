using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TICSET
{
    public partial class LoginWindow : Form
    {
        // Varaible for the registration window form.
        private RegisterWindow registrationWindow;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void lbl_new_user_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            registrationWindow = new RegisterWindow();
            registrationWindow.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text))
            {
                errorProvider1.SetError(tb_username, "Please provide a username.");
            }

            //if (this.ValidateChildren(ValidationConstraints.Enabled))
            //{
                
            //}
            //else
            //{

            //}
        }

        private void tb_username_Validating(Object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.tb_username.Text))
            {
                // Fails validation, display error message
                cancel = true;
                this.errorProvider1.SetError(tb_username, "Please provide a username");
            }
            e.Cancel = cancel;
        }

        private void tb_password_Validating(Object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.tb_password.Text))
            {
                // Fails validation, display error message
                cancel = true;
                this.errorProvider1.SetError(tb_password, "Please provide a username");
            }
            e.Cancel = cancel;
        }
    }
}
