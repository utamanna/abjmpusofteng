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

<<<<<<< HEAD
<<<<<<< HEAD
            game = gam;
            settings = gs;

        }
        public void drawMove(int pos, char piece)
        {
            Button tmp = ButtonArray[pos];
            tmp.Text = "" + piece; //type convert to string
        }


        private void DrawCharacter(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;

            game.makeMove(getButtonPos(tmp));

        }


=======
=======
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
        }
        public void drawMove(int pos, char piece)
        {
            Button tmp = ButtonArray[pos];
            tmp.Text = "" + piece; //type convert to string
        }


        private void DrawCharacter(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;

            game.makeMove(getButtonPos(tmp));

        }


<<<<<<< HEAD
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
=======
>>>>>>> 5a2b97b7a2390f5beb4d75a8f3de030e4e0b0e88
        private void button28_Click(object sender, EventArgs e)
        {

            // this.Close();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();


            }
        }
    }
}
