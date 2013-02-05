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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            X_1.Visible = false;
            X_2.Visible = false;
            X_3.Visible = false;
            X_4.Visible = false;
            X_5.Visible = false;
            X_6.Visible = false;
            X_7.Visible = false;
            X_8.Visible = false;
            X_9.Visible = false;
            X_10.Visible = false;
            X_11.Visible = false;
            X_12.Visible = false;
            X_13.Visible = false;
            X_14.Visible = false;
            X_15.Visible = false;
            X_16.Visible = false;
            X_17.Visible = false;
            X_18.Visible = false;
            X_19.Visible = false;
            X_20.Visible = false;
            X_21.Visible = false;
            X_22.Visible = false;
            X_23.Visible = false;
            X_24.Visible = false;
            X_25.Visible = false;
            O_1.Visible = false;
            O_2.Visible = false;
            O_3.Visible = false;
            O_4.Visible = false;
            O_5.Visible = false;
            O_6.Visible = false;
            O_7.Visible = false;
            O_8.Visible = false;
            O_9.Visible = false;
            O_10.Visible = false;
            O_11.Visible = false;
            O_12.Visible = false;
            O_13.Visible = false;
            O_14.Visible = false;
            O_15.Visible = false;
            O_16.Visible = false;
            O_17.Visible = false;
            O_18.Visible = false;
            O_19.Visible = false;
            O_20.Visible = false;
            O_21.Visible = false;
            O_22.Visible = false;
            O_23.Visible = false;
            O_24.Visible = false;
            O_25.Visible = false;
        }
          private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
           
           
                X_1.Visible=true;
                Button1.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            O_2.Visible = true;
            button2.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TwoPlayerButton_Click(object sender, EventArgs e)
        {
             TwoPlayerButton.Enabled = false;
             label_1.Text  = "There will be two players, player 1 is X and player 2 is O ";
             OnePlayerbutton.Enabled = false;
        }

        private void OnePlayerbutton_Click(object sender, EventArgs e)
        {
            OnePlayerbutton.Enabled = false;
            label_1.Text = " There will be one player, Player 1 is X and the computer is O";
            TwoPlayerButton.Enabled = false;
        }

    }
}
