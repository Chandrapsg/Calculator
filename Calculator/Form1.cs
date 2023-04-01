using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        public static int historyFlag = 1;
        public static int MemoryFlag = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using MyCalculator!!");
            this.Close();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (historyFlag == 2)
            {
                panelstdnew.Visible = true;
                panelhistory.Visible = false;
                panelMemory.Visible = false;
                historyFlag = 1;
            }
            else
            {
                panelstdnew.Visible = false;
                panelhistory.Visible = true;
                panelMemory.Visible = false;
                historyFlag = 2;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (MemoryFlag == 2)
            {
                panelstdnew.Visible = true;
                panelMemory.Visible = false;
                panelhistory.Visible = false;
                MemoryFlag = 1;
            }
            else
            {
                panelstdnew.Visible = false;
                panelMemory.Visible = true;
                panelhistory.Visible = false;
                MemoryFlag = 2;
            }
        }
    }
}

