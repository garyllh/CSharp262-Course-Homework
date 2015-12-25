using BookingLibrary;
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

namespace BookingSystem
{
    public partial class Form1 : Form
    {
        private Booking booking = new Booking();
        private string[] readyCheckSeatNO;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            numberBox.Text = b.Text;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            booking.ResetSeat();
            numberBox.Text = "0";
            clearScreen();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int people;
            string resultString;
            string[] searchResult;

            clearScreen();

            if (int.TryParse(numberBox.Text, out people))
            {
                if (people > 0 && people <= 51)
                {
                    resultString = booking.StartSearch(people);
                    if (resultString != "")
                    {
                        searchResult = resultString.Split('|');
                        foreach (string value in searchResult)
                        {
                            listView1.Items.Add(value);
                        }
                        labelmessage.Text = "(請點選座位群組,查看位置所在)";
                    }
                    else
                    {
                        MessageBox.Show("無 " + people + " 人的連續座位!!");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入1 - 51的數字!");
                }
            }
            else
            {
                MessageBox.Show("請輸入1 - 51的數字!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var parent = this.FindForm();

            if (listView1.SelectedItems.Count > 0)
            {
                resetSeatColor();
                this.readyCheckSeatNO = listView1.SelectedItems[0].Text.Split(',');

                for (int i = 1; i < 69; i++)
                {
                    var findchair = parent.Controls.Find("label" + i.ToString(), true).FirstOrDefault();
                    if (findchair != null)
                    {
                        // findchair.BackColor = Color.FromArgb(224, 224, 224);
                        if (Array.IndexOf(this.readyCheckSeatNO, findchair.Text) > -1)
                            findchair.BackColor = Color.Orange;
                    }
                }
            }
        }

        public void resetSeatColor()
        {
            string[] isChecked = booking.FindChecked();

            restcount.Text = (51 - isChecked.Length).ToString();

            for (int i = 1; i < 69; i++)
            {
                var findChair = this.FindForm().Controls.Find("label" + i.ToString(), true).FirstOrDefault();
                if (findChair != null)
                {
                    findChair.BackColor = Array.IndexOf(isChecked, findChair.Text) > -1 ?
                        Color.FromArgb(224, 0, 0) :
                        Color.FromArgb(224, 224, 224);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.readyCheckSeatNO != null)
            {
                booking.Booked(this.readyCheckSeatNO);
                clearScreen();
            }
            else
            {
                MessageBox.Show("尚未選擇座位!!");
            }
        }

        private void clearScreen()
        {
            resetSeatColor();
            this.readyCheckSeatNO = null;
            listView1.Items.Clear();
            labelmessage.Text = "";
        }
    }
}