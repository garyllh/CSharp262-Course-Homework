using GuessNumberLibrary;
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

namespace GuessNumberForComputer_Form
{
    public partial class Form1 : Form
    {
        private GuessNumber objectGN;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objectGN = new GuessNumber();
            objectGN.HowManytimes = 1;
            objectGN.Init();
            labelResultMessage.Text = "請輸入執行次數，然後點選[開始執行]....";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();

            buttonStart.Enabled = true;
            labelResultMessage.Text = "";
            textBox1.Text = "";
            textBox1.Focus();
            labelResultMessage.Text = "請輸入執行次數，然後點選[開始執行]....";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int howManyTimes;  //設定總共出幾題
            int[] answer; //題目答案

            int count = 0;  //出題次數累計

            int countGuessTimes = 0;  //每題猜的次數

            int[] guess;  //每次猜的號碼
            int[] returnAnswerArray;  //比對後的結果
            int sumEachGuessTimes = 0; //每題所猜次數的合計

            ListViewItem i1;
            ListViewItem.ListViewSubItem sub_i1, sub_i2;

            string tempCountString;

            if (!int.TryParse(textBox1.Text, out howManyTimes))
            {
                MessageBox.Show("請輸入執行次數(數字)!!");
                return;
            }
            else
            {
                objectGN.HowManytimes = howManyTimes;
                buttonStart.Enabled = false;
            }
            objectGN.FileCreate();
            labelResultMessage.Text = "執行中.................";
            while (count < objectGN.HowManytimes)
            {
                count++;
                countGuessTimes = 0;
                this.objectGN.Reset();
                answer = objectGN.GenerateAnswerNumber();

                while (true)
                {
                    countGuessTimes++;

                    guess = objectGN.GetGuessCode();
                    returnAnswerArray = objectGN.Compare(guess, answer);

                    objectGN.WriteLog(count, countGuessTimes, guess, returnAnswerArray);
                    if (returnAnswerArray[0] == 4 && returnAnswerArray[1] == 0)
                    {
                        sumEachGuessTimes += countGuessTimes;
                        break;
                    }
                    objectGN.DeleteNumber(guess, returnAnswerArray);
                }
                tempCountString = "00000" + count.ToString();
                i1 = new ListViewItem(tempCountString.Substring(tempCountString.Length - 5));
                sub_i1 = new ListViewItem.ListViewSubItem();
                sub_i2 = new ListViewItem.ListViewSubItem();

                sub_i1.Text = string.Join("", answer);
                sub_i2.Text = countGuessTimes.ToString();
                i1.SubItems.Add(sub_i1);
                i1.SubItems.Add(sub_i2);
                listView1.Items.Add(i1);
            }
            labelResultMessage.Text = "執行 " + objectGN.HowManytimes + " 題,平均每題使用 " +
                Math.Round((float)sumEachGuessTimes / (float)objectGN.HowManytimes, 2)
                + " 次(點選各題編號可顯示每次記錄)";
            objectGN.CloseFileInput();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList myArrayList;
            ListViewItem i1;
            ListViewItem.ListViewSubItem sub_i1, sub_i2, sub_i3;
            string temp11;

            if (listView1.SelectedItems.Count > 0)
            {
                listView2.Items.Clear();
                temp11 = listView1.SelectedItems[0].Text;
                myArrayList = objectGN.ReadLog(temp11);
                foreach (string[] obj in myArrayList)
                {
                    i1 = new ListViewItem(obj[0].Substring(1, 5));

                    sub_i1 = new ListViewItem.ListViewSubItem();
                    sub_i2 = new ListViewItem.ListViewSubItem();
                    sub_i3 = new ListViewItem.ListViewSubItem();

                    sub_i1.Text = obj[1];
                    sub_i2.Text = obj[2];
                    sub_i3.Text = obj[3];
                    i1.SubItems.Add(sub_i1);
                    i1.SubItems.Add(sub_i2);
                    i1.SubItems.Add(sub_i3);

                    listView2.Items.Add(i1);
                }
            }
        }
    }
}