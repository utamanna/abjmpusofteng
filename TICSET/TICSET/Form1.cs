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
using gamePlay;

namespace TICSET
{
    public partial class Form1 : Form
    {
        private Settings settings;
        public Game game;

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
        }
        private int getButtonPos(Button b)
        {
            string name = b.Name;
            name = name.Replace("button", "");
            name = name.Replace("Button", "");
            int i = Convert.ToInt32(name);
            return i - 1;
        }

        public Form1(Settings gs, Game gam)
        {
            game = gam;
            settings = gs;
            InitializeComponent();
        }

        public void drawMove(int pos, char piece)
        {
            Button tmp = ButtonArray[pos];

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
                tmp.Text = "" + piece; //type convert to string
                isX = !isX;
            }
            this.isGameOver = IsGameOver(ButtonArray) || CheckDraw(ButtonArray);

        }

        //========================
        // ADDED 4/16/2013 - Usman
        //========================
        public void gameOver(int[] winningPattern, char winningPiece)
        {
            foreach( int i in winningPattern )
            {
                ButtonArray[i].BackColor = Color.Red;
                MessageBox.Show("Game Over. " + winningPattern + " wins!");

            }
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
            for (int i = 0; i < 28; i++)
            {
                int a = winPattern[i, 0], b = winPattern[i, 1], c = winPattern[i, 2], d = winPattern[i, 3];//,e=winPattern[i,4],f=winPattern[i,5];		

                Button b1 = btnCtrl[a], b2 = btnCtrl[b], b3 = btnCtrl[c], b4 = btnCtrl[d];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "" || b4.Text == "")
                    continue;

                if (b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == b4.Text)
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = b4.BackColor = Color.Red;
                    b1.Font = b2.Font = b3.Font = b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Italic & System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                    gameOver = true;
                    MessageBox.Show("Game Over. " + b1.Text + " wins");
                }
            }
            return gameOver;
        }
        
        private void DrawCharacter(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            game.makeMove(getButtonPos(tmp));
        }


        private void button28_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            Gameover go = Gameover();
        }
    }
}