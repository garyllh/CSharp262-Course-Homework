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

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("3");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber("0");
        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonNumber(".");
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonAction("+");
        }

        private void buttondec_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonAction("-");
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonAction("*");
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonAction("/");
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonAction("=");
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

        private void buttonleft_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonSpecial('<');
        }

        private void buttonpd_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonSpecial('n');
        }

        private void buttonpercent_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonSpecial('%');
        }

        private void buttondown_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonSpecial('d');
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            display.Text = calculator.ButtonSpecial('v');
        }

        private void buttonmc_Click(object sender, EventArgs e)
        {
            display.Text = calculator.MemoryHandle('c');
            labelm.Visible = calculator.isVisibleMemoryLabel;
        }

        private void buttonmr_Click(object sender, EventArgs e)
        {
            display.Text = calculator.MemoryHandle('r');
            labelm.Visible = calculator.isVisibleMemoryLabel;
        }

        private void buttonms_Click(object sender, EventArgs e)
        {
            display.Text = calculator.MemoryHandle('s');
            labelm.Visible = calculator.isVisibleMemoryLabel;
        }

        private void buttonmplus_Click(object sender, EventArgs e)
        {
            display.Text = calculator.MemoryHandle('+');
            labelm.Visible = calculator.isVisibleMemoryLabel;
        }

        private void buttonmdec_Click(object sender, EventArgs e)
        {
            display.Text = calculator.MemoryHandle('-');
            labelm.Visible = calculator.isVisibleMemoryLabel;
        }
    }
}