using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Random ran = new Random();
            int rNum = ran.Next(1, 5);
            if (rNum == 1)
            {
                label1.Text = "1 Was Correct!";
            }
            else
            {
                label1.Text = "1 was incorrect, " + rNum + " was correct";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Random ran = new Random();
            int rNum = ran.Next(1, 5);
            if (rNum == 2)
            {
                label1.Text = "2 Was Correct!";
            }
            else
            {
                label1.Text = "2 was incorrect, " + rNum + " was correct";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random ran = new Random();
            int rNum = ran.Next(1, 5);
            if (rNum == 3)
            {
                label1.Text = "3 Was Correct!";
            }
            else
            {
                label1.Text = "3 was incorrect, " + rNum + " was correct";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Random ran = new Random();
            int rNum = ran.Next(1, 5);
            if (rNum == 4)
            {
                label1.Text = "4 Was Correct!";
            }
            else
            {
                label1.Text = "4 was incorrect, " + rNum + " wascorrect";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Random ran = new Random();
            int rNum = ran.Next(1, 5);
            if (rNum == 5)
            {
                label1.Text = "5 Was Correct!";
            }
            else
            {
                label1.Text = "5 was incorrect, " + rNum + " was correct";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
