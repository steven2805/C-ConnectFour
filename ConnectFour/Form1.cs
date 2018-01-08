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
        int turn_count = 0;



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

            turn = !turn;
            turn_count++;
            b.Enabled = false;

            checkForWinner();
        }


        private void checkForWinner()
        {
            bool isWinning = false;

            if (((button01.Text == button2.Text) && (button2.Text == button3.Text) && (!button01.Enabled))
                 || ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button3.Enabled))
                 || (button7.Text == button6.Text) && (button6.Text == button9.Text) && (!button7.Enabled))
            {
                isWinning = true;
            }


            if (isWinning || turn_count == 9)
            {
                foreach(Control ctrl in Controls)
                {
                    ctrl.Enabled = false;
                    if(ctrl.Name == "menuStrip2")
                    {
                        ctrl.Enabled = true;
                    };
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
