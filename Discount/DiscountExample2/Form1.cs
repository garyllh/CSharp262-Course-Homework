using DiscountClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountExample2
{
    public partial class Form1 : Form
    {
        private MovieTicket childTicket = new ChildrenTicket();
        private MovieTicket studentTicket = new StudentTicket();
        private MovieTicket adultTicket = new AdultTicket();
        private TicketDiscountNameList discountList;

        private double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            discountList = new TicketDiscountNameList();
            list = discountList.GetChildDiscountList();

            foreach (string[] value in list)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = value[1];
                item.Value = value[0];
                comboBoxChildDiscount.Items.Add(item);
            }
            comboBoxChildDiscount.SelectedIndex = 0;

            list = discountList.GetStudentDiscountList();
            foreach (string[] value in list)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = value[1];
                item.Value = value[0];
                comboBoxStudentDiscount.Items.Add(item);
            }
            comboBoxStudentDiscount.SelectedIndex = 0;

            list = discountList.GetVipDiscountList();
            foreach (string[] value in list)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = value[1];
                item.Value = value[0];
                comboBoxAdultDiscount.Items.Add(item);
            }
            comboBoxAdultDiscount.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            ChangeLabelColor(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strvalue;
            int tickets;

            if (!int.TryParse(textBox1.Text, out tickets))
            {
                MessageBox.Show("請輸入訂票張數!!");
                return;
            }
            if (comboBox1.SelectedIndex == 0)  //全票
            {
                strvalue = (comboBoxAdultDiscount.SelectedItem as ComboboxItem).Value.ToString();
                adultTicket.SetDiscount(discountList.SelectDiscount(0, strvalue));
                textBox2.Text += adultTicket.Display2() + ",共 " + tickets.ToString() + " 張,小計：" + (tickets * adultTicket.price).ToString() + "\r\n";
                total += tickets * adultTicket.price;
            }
            if (comboBox1.SelectedIndex == 1)  //學生票
            {
                strvalue = (comboBoxStudentDiscount.SelectedItem as ComboboxItem).Value.ToString();
                studentTicket.SetDiscount(discountList.SelectDiscount(1, strvalue));
                textBox2.Text += studentTicket.Display2() + ",共 " + tickets.ToString() + " 張,小計：" + (tickets * studentTicket.price).ToString() + "\r\n";
                total += tickets * studentTicket.price;
            }
            if (comboBox1.SelectedIndex == 2)  //兒童票
            {
                strvalue = (comboBoxChildDiscount.SelectedItem as ComboboxItem).Value.ToString();
                childTicket.SetDiscount(discountList.SelectDiscount(2, strvalue));
                textBox2.Text += childTicket.Display2() + ",共 " + tickets.ToString() + " 張,小計：" + (tickets * childTicket.price).ToString() + "\r\n";
                total += tickets * childTicket.price;
            }

            label7.Text = total.ToString();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            textBox1.Text = bt.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBoxChildDiscount.SelectedIndex = 0;
            comboBoxStudentDiscount.SelectedIndex = 0;
            comboBoxAdultDiscount.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            textBox1.Clear();
            textBox2.Clear();
            total = 0;
            label7.Text = "0";
        }

        public void ChangeLabelColor(int num)
        {
            label4.ForeColor = num == 0 ? Color.FromArgb(255, 0, 0) : Color.FromArgb(0, 0, 0);
            label3.ForeColor = num == 1 ? Color.FromArgb(255, 0, 0) : Color.FromArgb(0, 0, 0);
            label2.ForeColor = num == 2 ? Color.FromArgb(255, 0, 0) : Color.FromArgb(0, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLabelColor(comboBox1.SelectedIndex);
        }
    }
}