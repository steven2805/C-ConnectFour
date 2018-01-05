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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is the button press");
            System.Console.WriteLine("this is testing");
            
        }

        private void button_click(object sender, EventArgs e)
        {
            MessageBox.Show("this is the button press testimg");
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;



        }
    }
}
