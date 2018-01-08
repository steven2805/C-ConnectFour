using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{


    public partial class Form1 : Form
    {
        bool turn = true; // When true = X; when false = O;
        int turn_count = 0; // keeps track of the game turn count;
    

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Steven", "Simple game");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn; // swaps the current player;
            turn_count++;  // adds an additonal button click to the overall count;
            b.Enabled = false; // disables the button thats been choosen;
             
            checkForWinner();
        }


        private void checkForWinner()
        {
            bool isWinning = false;

            if (((button01.Text == button2.Text) && (button2.Text == button3.Text) && (!button01.Enabled))
            || ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
            || (button7.Text == button6.Text) && (button6.Text == button9.Text) && (!button7.Enabled))
            {
                isWinning = true;
            }

           if (((button01.Text == button4.Text) && (button7.Text == button01.Text) && (!button01.Enabled))
           || ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
           || (button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
            {
                isWinning = true;
            }

            if (((button01.Text == button5.Text) && (button5.Text == button9.Text) && (!button01.Enabled))
                || ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button2.Enabled)))
            {
                isWinning = true;
            }



            if (isWinning || turn_count == 9)
            {
                foreach(Control ctrl in Controls)
                {
                    if(ctrl.Name == "menuStrip2")
                    {
                        ctrl.Enabled = true;
                    }
                    else
                    {
                        ctrl.Enabled = false;
                    }
                }
                if (turn_count == 9)
                {
                    MessageBox.Show("draw");
                }
                else
                {
                   MessageBox.Show("winning");
                }              
            }
         
        }
    }
}
