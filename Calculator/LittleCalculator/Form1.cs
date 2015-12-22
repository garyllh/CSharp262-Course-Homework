using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleCalculator
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            display.Text = calculator.ButtonNumber(b.Text);
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            display.Text = calculator.ButtonAction(b.Text);
        }

        private void buttonSpecial_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            display.Text = calculator.ButtonSpecial((String)b.Tag);
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            calculator.DisplayString = "0";
            display.Text = "0";
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            calculator.Refresh();
            display.Text = "0";
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            display.Text = calculator.MemoryHandle((String)b.Tag);
            labelm.Visible = calculator.isVisibleMemoryLabel;
        }
    }
}