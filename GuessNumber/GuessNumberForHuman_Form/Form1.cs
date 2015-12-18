using GuessNumberLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberForHuman_Form
{
    public partial class Form1 : Form
    {
        private GuessNumber objectGN;
        private int[] answer;
        private int countNo = 0;
        private string guessString;
        private string[] guessStringTemp;
        private int[] guess = new int[4];
        private string[] guessLabel = new string[4] { "", "", "", "" };
        private string retry;
        private int[] result;
        private int isEnd = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleNumberButtonClick(object sender, int number)
        {
            Button theButton = sender as Button;
            for (int i = 0; i < 4; i++)
            {
                if (guessLabel[i] == "")
                {
                    guessLabel[i] = number.ToString();
                    theButton.Enabled = false;
                    theButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    break;
                }
            }
            label1.Text = guessLabel[0];
            label2.Text = guessLabel[1];
            label3.Text = guessLabel[2];
            label4.Text = guessLabel[3];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objectGN = new GuessNumber();
            objectGN.HowManaytimes = 1;
            answer = objectGN.GenerateAnswerNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.HandleNumberButtonClick(sender, 0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm();
            for (int i = 0; i < 10; i++)
            {
                var findButton = parent.Controls.Find("button" + i.ToString(), true).FirstOrDefault();
                if (findButton != null)
                {
                    findButton.Enabled = true;
                    findButton.BackColor = System.Drawing.SystemColors.Desktop;
                }
            }
            label1.Text = guessLabel[0] = "";
            label2.Text = guessLabel[1] = "";
            label3.Text = guessLabel[2] = "";
            label4.Text = guessLabel[3] = "";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            //check eror
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(guessLabel[i], out guess[i]))
                {
                    MessageBox.Show("請輸入4位數字!!", "錯誤訊息");
                    return;
                }
            }

            //check answer
            countNo++;
            result = objectGN.Compare(guess, answer);
            listView1.Items.Add((countNo < 10 ? '0' + countNo.ToString() : countNo.ToString()) + ".    " + string.Join("", guessLabel) + "    " + result[0] + "A" + result[1] + "B", 3);
            //scroll to end
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            if (result[0] == 4 && result[1] == 0)
            {
                isEnd = 1;
                buttonGuess.Enabled = false;
                listView1.Items[listView1.Items.Count - 1].BackColor = Color.Red;
                listView1.Items[listView1.Items.Count - 1].ForeColor = Color.White;
                MessageBox.Show("***  恭喜您答對了 ****", "訊息");
            }
            else
            {
                buttonClear.PerformClick();
            }
        }

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            if (isEnd == 0)
            {
                //show answer
                MessageBox.Show("正確數字是 " + string.Join("", answer) + " ,請按確定鍵!!", "訊息");
            }
            else
            {
                isEnd = 0;
                buttonGuess.Enabled = true;
            }

            answer = objectGN.GenerateAnswerNumber();
            countNo = 0;
            buttonClear.PerformClick();
            listView1.Items.Clear();
            buttonGuess.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}