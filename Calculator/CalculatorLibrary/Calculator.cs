using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        private double preData = 0;
        private string preAction = "";
        public bool resetClick = false;
        public string DisplayString = "0";
        public double memory = 0;
        public bool isVisibleMemoryLabel = false;

        public void Refresh()
        {
            preData = 0;
            preAction = "";
            resetClick = false;
            DisplayString = "0";
        }

        public string ButtonNumber(string btnValue)
        {
            if (resetClick)
            {
                DisplayString = (btnValue == "." ? "0." : btnValue);
                resetClick = false;
            }
            else
            {
                if (DisplayString.Length < 16)
                {
                    if (btnValue == ".")
                    {
                        DisplayString += btnValue;
                    }
                    else
                    {
                        DisplayString = (DisplayString == "0" ? "" : DisplayString) + btnValue;
                    }
                }
            }
            return DisplayString;
        }

        public string ButtonAction(string btnAction)
        {
            string result;
            if (preAction == "")
            {
                preData = double.Parse(DisplayString);
                result = DisplayString;
            }
            else
            {
                switch (preAction)
                {
                    case "+":
                        preData = preData + double.Parse(DisplayString);

                        break;

                    case "-":
                        preData = preData - double.Parse(DisplayString);

                        break;

                    case "*":
                        preData = preData * double.Parse(DisplayString);

                        break;

                    case "/":
                        preData = preData / double.Parse(DisplayString);

                        break;
                }
                result = preData.ToString();
            }
            if (btnAction == "=")
            {
                preAction = "";
                DisplayString = result;
            }
            else
            {
                preAction = btnAction;
            }
            resetClick = true;
            return result;
        }

        public string MemoryHandle(char type)
        {
            switch (type)
            {
                case 'c':
                    this.memory = 0;
                    isVisibleMemoryLabel = false;
                    break;

                case 'r':
                    if (isVisibleMemoryLabel)
                    {
                        this.DisplayString = this.memory.ToString();
                    }

                    break;

                case 's':
                    this.memory = double.Parse(this.DisplayString);
                    isVisibleMemoryLabel = true;
                    break;

                case '+':
                    this.memory += double.Parse(this.DisplayString);
                    isVisibleMemoryLabel = true;
                    break;

                case '-':
                    this.memory -= double.Parse(this.DisplayString);
                    isVisibleMemoryLabel = true;
                    break;
            }
            resetClick = true;
            return this.DisplayString;
        }

        public string ButtonSpecial(char type)
        {
            string temp;
            switch (type)
            {
                case '<':
                    if (!resetClick)
                    {
                        temp = this.DisplayString.Substring(0, this.DisplayString.Length - 1);
                        this.DisplayString = (temp == "" || temp == "-" || temp == "-0" ? "0" : temp);
                    }
                    break;

                case 'n':
                    this.DisplayString = (double.Parse(this.DisplayString) * (-1)).ToString();
                    break;

                case 'v':
                    this.DisplayString = Math.Sqrt(double.Parse(this.DisplayString)).ToString();
                    break;

                case '%':
                    this.DisplayString = (double.Parse(this.DisplayString) / (100)).ToString();
                    break;

                case 'd':
                    this.DisplayString = (1 / double.Parse(this.DisplayString)).ToString();
                    break;
            }
            return this.DisplayString;
        }
    }
}