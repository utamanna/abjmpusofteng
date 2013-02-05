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
          private void Xs_button_Click(object sender, EventArgs e)
          {
              Xs_button.Enabled = false;
          }
          private void Os_bttuon_Click(object sender, EventArgs e)
          {
              Os_button.Enabled = false;

          }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_1.Visible = true;
                O_1.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;
                Button1.Enabled = false;


            }
            else
            {

                X_1.Visible = true;
                // Button1.Text = "X";
                X_1.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
                Button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_2.Visible = true;
                O_2.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_2.Visible = true;
                // Button1.Text = "X";
                X_2.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_3.Visible = true;
                O_3.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_3.Visible = true;
                // Button1.Text = "X";
                X_3.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_4.Visible = true;
                O_4.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_4.Visible = true;
                // Button1.Text = "X";
                X_4.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }

        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_5.Visible = true;
                O_5.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_5.Visible = true;
                // Button1.Text = "X";
                X_5.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_6.Visible = true;
                O_6.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_6.Visible = true;
                // Button1.Text = "X";
                X_6.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_7.Visible = true;
                O_7.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_7.Visible = true;
                // Button1.Text = "X";
                X_7.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_8.Visible = true;
                O_8.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_8.Visible = true;
                //Button1.Text = "X";
                X_8.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_9.Visible = true;
                O_9.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_9.Visible = true;
                // Button1.Text = "X";
                X_9.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_10.Visible = true;
                O_10.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_10.Visible = true;
                // Button1.Text = "X";
                X_10.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_11.Visible = true;
                O_11.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_11.Visible = true;
                // Button1.Text = "X";
                X_11.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_12.Visible = true;
                O_12.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_12.Visible = true;
                // Button1.Text = "X";
                X_12.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_13.Visible = true;
                O_13.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_13.Visible = true;
                // Button1.Text = "X";
                X_13.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_14.Visible = true;
                O_14.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_14.Visible = true;
                // Button1.Text = "X";
                X_14.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_15.Visible = true;
                O_15.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_15.Visible = true;
                // Button1.Text = "X";
                X_15.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_16.Visible = true;
                O_16.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_16.Visible = true;
                // Button1.Text = "X";
                X_16.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_17.Visible = true;
                O_17.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_17.Visible = true;
                // Button1.Text = "X";
                X_17.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_18.Visible = true;
                O_18.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_18.Visible = true;
                // Button1.Text = "X";
                X_18.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_19.Visible = true;
                O_19.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_19.Visible = true;
                // Button1.Text = "X";
                X_19.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_20.Visible = true;
                O_20.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_20.Visible = true;
                // Button1.Text = "X";
                X_20.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_21.Visible = true;
                O_21.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_21.Visible = true;
                // Button1.Text = "X";
                X_21.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_22.Visible = true;
                O_22.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_22.Visible = true;
                // Button1.Text = "X";
                X_22.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_23.Visible = true;
                O_23.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_23.Visible = true;
                // Button1.Text = "X";
                X_23.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_24.Visible = true;
                O_24.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_24.Visible = true;
                // Button1.Text = "X";
                X_24.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {

                O_25.Visible = true;
                O_25.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {

                X_25.Visible = true;
                // Button1.Text = "X";
                X_25.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
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
