//int blockweight;
//int streak weight

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
        // Variables for who goes first
        //private bool xGoesFirst = false;
        //private bool oGoesFirst = false;
        //private bool whoGoesFirstChosen = false;
        // End

        private Button[] ButtonArray;
        private bool isX;
        private bool isGameOver;
        private int[,] winPattern ={
            {0,1,2,3},
            {1,2,3,4},
            {5,6,7,8},
            {6,7,8,9},
            {10,11,12,13},
            {11,12,13,14},
            {15,16,17,18},
            {16,17,18,19},
            {20,21,22,23},
            {21,22,23,24},
            {4,8,12,16},
            {0,5,10,15},
            {5,10,15,20},
            {1,6,11,16},
            {6,11,16,21},
            {2,7,12,17},
            {7,12,17,22},
            {3,8,13,18},
            {8,13,18,23},
            {4,9,14,19},
            {9,14,19,24},
            {0,6,12,18},
            {6,12,18,24},
            {5,11,17,23},
            {1,7,13,19},
            {3,7,11,15},
            {8,12,16,20},
            {9,13,17,21}};
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonArray = new Button[25]{Button1, button2, button3, button4, button5,
                                         button6, button7, button8, button9, button10,
                                         button11,button12,button13,button14,button15,
                                         button16, button17, button18, button19, button20,
                                         button21, button22, button23, button24, button25};
            foreach (Button ctrlBtn in ButtonArray)
            {
                ctrlBtn.Click += new System.EventHandler(this.DrawCharacter);
                ctrlBtn.Text = "";
                ctrlBtn.BackColor = Color.Transparent;
                ctrlBtn.Font = new System.Drawing.Font("Comic Sans MS", 40f,
                                                         System.Drawing.FontStyle.Bold,
                                                         System.Drawing.GraphicsUnit.Point,
                                                         ((System.Byte)(0)));
            }
            //InitGame();
        }

        //private void InitGame()
        //{
        //    foreach (Button btn in ButtonArray)
        //    {
        //        btn.Text = "";
        //        btn.BackColor = Color.Transparent;
        //        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        //    }
        //    isGameOver = false;
        //    isX = true;
        //}
        public Form1()
        {
            InitializeComponent();
            
            //Button1.Enabled = false;
            //button2.Enabled = false;
            //button3.Enabled = false;
            //button4.Enabled = false;
            //button5.Enabled = false;
            //button6.Enabled = false;
            //button7.Enabled = false;
            //button8.Enabled = false;
            //button9.Enabled = false;
            //button10.Enabled = false;
            //button11.Enabled = false;
            //button12.Enabled = false;
            //button13.Enabled = false;
            //button14.Enabled = false;
            //button15.Enabled = false;
            //button16.Enabled = false;
            //button17.Enabled = false;
            //button18.Enabled = false;
            //button19.Enabled = false;
            //button20.Enabled = false;
            //button21.Enabled = false;
            //button22.Enabled = false;
            //button23.Enabled = false;
            //button24.Enabled = false;
            //button25.Enabled = false;

        //    ButtonArray = new Button[25]{Button1,button2, button3,button4,button5,button6,button7,button8,button9,button10,button11,button12,button13,button14,button15,button16,button17,button18,button19,button20
        //,button21,button22,button23,button24,button25};
        //    foreach (Button ctrlBtn in ButtonArray)
        //    {
        //        ctrlBtn.Enabled = false;
        //        ctrlBtn.Click += new System.EventHandler(this.DrawCharacter);
        //        ctrlBtn.Text = "";
        //        ctrlBtn.BackColor = Color.Transparent;
        //        ctrlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        //    }
        //    isGameOver = false;
        //    isX = true;
            //InitGame();
        }

        private bool CheckDraw(Button[] btnCtrl)
        {
            foreach (Button btn in btnCtrl)
            {
                if (btn.Text == "")
                    return false;
            }
            MessageBox.Show("Game Draw");

            return true;
        }
         private bool IsGameOver(Button[] btnCtrl)
        {
            bool gameOver = false;
            for (int i = 0; i < 25; i++)
            {
                int a = winPattern[i, 0], b = winPattern[i, 1], c = winPattern[i, 2],d = winPattern[i,3];//,e=winPattern[i,4],f=winPattern[i,5];		
                
                Button b1 = btnCtrl[a], b2 = btnCtrl[b], b3 = btnCtrl[c],b4=btnCtrl[d];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "" || b4.Text == "")	
                    continue;

                if (b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == b4.Text)			
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = b4.BackColor=Color.Red;
                    b1.Font = b2.Font = b3.Font = b4.Font=new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Italic & System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                    gameOver = true;
                    MessageBox.Show("Game Over. " + b1.Text + " wins");                                        
                }
            }
            return gameOver;
        }

         private void DrawCharacter(object sender, EventArgs e)
         {
             Button tmp = (Button)sender;

             if (this.isGameOver)
             {
                 MessageBox.Show("Game Over");
             }

             if (tmp.Text != "")
             {
                 MessageBox.Show("Move not allowed", "Incorrect Move");
             }
             else
             {
                 tmp.Text = (isX) ? "X" : "O";
                 isX = !isX;
             }
             this.isGameOver = IsGameOver(ButtonArray) || CheckDraw(ButtonArray);

         }
             

        private void button28_Click(object sender, EventArgs e)
        {

           // this.Close();
            for (int i= Application.OpenForms.Count-1;i>=0;i--)

            {
                Application.OpenForms[i].Close();


            }
        }
        //private void TwoPlayerButton_Click(object sender, EventArgs e)
        //{
        //     TwoPlayerButton.Enabled = false;
        //     label_1.Text  = "\n  Two players\n  Player One is X\n  Player Two is O ";
        //     OnePlayerbutton.Enabled = false;
            
        //}

        //private void OnePlayerbutton_Click(object sender, EventArgs e)
        //{
        //    OnePlayerbutton.Enabled = false;
        //    label_1.Text = " There will be one player, Player 1 is X and the computer is O";
        //    TwoPlayerButton.Enabled = false;
        //    Button1.Enabled = true;
        //    button2.Enabled = true;
        //    button3.Enabled = true;
        //    button4.Enabled = true;
        //    button5.Enabled = true;
        //    button6.Enabled = true;
        //    button7.Enabled = true;
        //    button8.Enabled = true;
        //    button9.Enabled = true;
        //    button10.Enabled = true;
        //    button11.Enabled = true;
        //    button12.Enabled = true;
        //    button13.Enabled = true;
        //    button14.Enabled = true;
        //    button15.Enabled = true;
        //    button16.Enabled = true;
        //    button17.Enabled = true;
        //    button18.Enabled = true;
        //    button19.Enabled = true;
        //    button20.Enabled = true;
        //    button21.Enabled = true;
        //    button22.Enabled = true;
        //    button23.Enabled = true;
        //    button24.Enabled = true;
        //    button25.Enabled = true;
        //}

        //private void Xs_button_Click(object sender, EventArgs e)
        //{
        //    isX = true; // Controls who goes first, in this case X goes first
        //    Xs_button.Enabled = false;
        //    Os_button.Enabled = false;
        //    Button1.Enabled = true;
        //    button2.Enabled = true;
        //    button3.Enabled = true;
        //    button4.Enabled = true;
        //    button5.Enabled = true;
        //    button6.Enabled = true;
        //    button7.Enabled = true;
        //    button8.Enabled = true;
        //    button9.Enabled = true;
        //    button10.Enabled = true;
        //    button11.Enabled = true;
        //    button12.Enabled = true;
        //    button13.Enabled = true;
        //    button14.Enabled = true;
        //    button15.Enabled = true;
        //    button16.Enabled = true;
        //    button17.Enabled = true;
        //    button18.Enabled = true;
        //    button19.Enabled = true;
        //    button20.Enabled = true;
        //    button21.Enabled = true;
        //    button22.Enabled = true;
        //    button23.Enabled = true;
        //    button24.Enabled = true;
        //    button25.Enabled = true;
        //}
        //private void Os_bttuon_Click(object sender, EventArgs e)
        //{
        //    isX = false; // Controls who goes first, in this case O goes first
        //    Xs_button.Enabled = false;
        //    Os_button.Enabled = false;
        //    Button1.Enabled = true;
        //    button2.Enabled = true;
        //    button3.Enabled = true;
        //    button4.Enabled = true;
        //    button5.Enabled = true;
        //    button6.Enabled = true;
        //    button7.Enabled = true;
        //    button8.Enabled = true;
        //    button9.Enabled = true;
        //    button10.Enabled = true;
        //    button11.Enabled = true;
        //    button12.Enabled = true;
        //    button13.Enabled = true;
        //    button14.Enabled = true;
        //    button15.Enabled = true;
        //    button16.Enabled = true;
        //    button17.Enabled = true;
        //    button18.Enabled = true;
        //    button19.Enabled = true;
        //    button20.Enabled = true;
        //    button21.Enabled = true;
        //    button22.Enabled = true;
        //    button23.Enabled = true;
        //    button24.Enabled = true;
        //    button25.Enabled = true;
        //}

        //private void resetButton_Click(object sender, EventArgs e)
        //{
        //    InitializeComponent();

        //    Button1.Enabled = false;
        //    button2.Enabled = false;
        //    button3.Enabled = false;
        //    button4.Enabled = false;
        //    button5.Enabled = false;
        //    button6.Enabled = false;
        //    button7.Enabled = false;
        //    button8.Enabled = false;
        //    button9.Enabled = false;
        //    button10.Enabled = false;
        //    button11.Enabled = false;
        //    button12.Enabled = false;
        //    button13.Enabled = false;
        //    button14.Enabled = false;
        //    button15.Enabled = false;
        //    button16.Enabled = false;
        //    button17.Enabled = false;
        //    button18.Enabled = false;
        //    button19.Enabled = false;
        //    button20.Enabled = false;
        //    button21.Enabled = false;
        //    button22.Enabled = false;
        //    button23.Enabled = false;
        //    button24.Enabled = false;
        //    button25.Enabled = false;
        //}


    }

}



/*
        private void Button1_Click(object sender, EventArgs e)
          {   
              if (oGoesFirst)
              {
                  Button1.Text = "O";                 // O_1.Visible = true;
                 // O_1.BringToFront();
                  Os_button.Enabled = true;
                  Xs_button.Enabled = false;
                 // Button1.Enabled = false;
                  
              }
              else
              {

                  Button1.Text = "X";
                 // X_1.Visible = true;
                 
                  // Button1.Text = "X";
                  //X_1.BringToFront();
                  Xs_button.Enabled = true;
                  Os_button.Enabled = false;
                  //Button1.Enabled = false;
              }
          }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button2.Text = "O";

               // O_2.Visible = true;
                //O_2.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button2.Text = "X";
          //      X_2.Visible = true;
                // Button1.Text = "X";
            //    X_2.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button3.Text = "O";
                //O_3.Visible = true;
                //O_3.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button3.Text = "X";
                //X_3.Visible = true;
                // Button1.Text = "X";
                //X_3.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button4.Text = "O";
                //O_4.Visible = true;
                //O_4.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button4.Text = "X";
                //X_4.Visible = true;
                // Button1.Text = "X";
                //X_4.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button5.Text = "O";
                //O_5.Visible = tue;
                //O_5.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button5.Text = "X";
                //X_5.Visible = true;
                // Button1.Text ="X";
                //X_5.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button6.Text = "O";
                //O_6.Visible = true;
                //O_6.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button6.Text = "X";
                //X_6.Visible = true;
                // Button1.Text = "X";
                //X_6.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button7.Text = "O";
                //O_7.Visible = true;
                //O_7.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button7.Text = "X";
                //X_7.Visible = true;
                // Button1.Text = "X";
                //X_7.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button8.Text = "O";
                //O_8.Visible = true;
                //O_8.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button8.Text = "X";
                //X_8.Visible = true;
                //Button1.Text = "X";
                //X_8.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button9.Text = "O";
                //O_9.Visible = true;
                //O_9.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button9.Text = "X";
                //X_9.Visible = true;
                // Button1.Text = "X";
                //X_9.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button10.Text = "O";
                //O_10.Visible = true;
                //O_10.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button10.Text = "X";
                //X_10.Visible = true;
                // Button1.Text = "X";
                //X_10.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button11.Text = "O";
                //O_11.Visible = true;
                //O_11.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button11.Text = "X";
                //X_11.Visible = true;
                // Button1.Text = "X";
                //X_11.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button12.Text = "O";
                //O_12.Visible = true;
                //O_12.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button12.Text = "X";
                //X_12.Visible = true;
                // Button1.Text = "X";
                //X_12.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button13.Text = "O";
                //O_13.Visible = true;
                //O_13.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button13.Text = "X";
                //X_13.Visible = true;
                // Button1.Text = "X";
                //X_13.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button14.Text = "O";
                //O_14.Visible = true;
                //O_14.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button14.Text = "X";
                //X_14.Visible = true;
                // Button1.Text = "X";
                //X_14.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button15.Text = "O";
                //O_15.Visible = true;
                //O_15.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button15.Text = "X";
                //X_15.Visible = true;
                // Button1.Text = "X";
                //X_15.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button16.Text = "O";
                //O_16.Visible = true;
                //O_16.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button16.Text = "X";
                //X_16.Visible = true;
                // Button1.Text = "X";
                //X_16.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button17.Text = "O";
                //O_17.Visible = true;
                //O_17.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button17.Text = "X";
                //X_17.Visible = rue;
                // Button1.Text = "X";
                //X_17.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button18.Text = "O";
                //O_18.Visible = true;
                //O_18.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button18.Text = "X";
                //X_18.Visible = true;
                // Button1.Text = "X";
                //X_18.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button19.Text = "O";
                //O_19.Visible = true;
                //O_19.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button19.Text = "X";
                //X_19.Visible = true;
                // Button1.Text = "X";
                //X_19.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button20.Text = "O";
                //O_20.Visible = true;
                //O_20.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button20.Text = "X";
                //X_20.Visible = true;
                // Button1.Text = "X";
                //X_20.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button21.Text = "O";
                //O_21.Visible = true;
                //O_21.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button21.Text = "X";
                //X_21.Visible = true;
                // Button1.Text = "X";
                //X_21.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button22.Text = "O";

                //O_22.Visible = true;
                //O_22.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button22.Text = "X";
                //X_22.Visible = true;
                // Button1.Text = "X";
                //X_22.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button23.Text = "O";
                //O_23.Visible = true;
                //O_23.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button23.Text = "X";
                //X_23.Visible = true;
                // Button1.Text = "X";
                //X_23.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button24.Text = "O";
                //O_24.Visible = true;
                //O_24.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button24.Text = "X";
                //X_24.Visible = true;
                // Button1.Text = "X";
              //  X_24.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (Xs_button.Enabled)
            {
                button25.Text = "O";
               // O_25.Visible = true;
                //O_25.BringToFront();
                Os_button.Enabled = true;
                Xs_button.Enabled = false;

            }
            else
            {
                button25.Text = "X";
                //X_25.Visible = true;
                // Button1.Text = "X";
               // X_25.BringToFront();
                Xs_button.Enabled = true;
                Os_button.Enabled = false;
            }
        }
*/