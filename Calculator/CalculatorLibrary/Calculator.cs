using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        private double preData = 0;  //之前計算後的值
        private string preAction = "";  //準備執行的動作
        public bool resetClick = false; //輸入數字鍵時,判斷是否要清除顯示的資料true:清除,false:加到最後
        public string DisplayString = "0";  //目前顯示的資料

        public double memory = 0;  //目前在 memory 的值
        public bool isVisibleMemoryLabel = false;  //顯示M

        //for C 鍵
        public void Refresh()
        {
            preData = 0;
            preAction = "";
            resetClick = false;
            DisplayString = "0";
        }

        //數字按鍵
        public string ButtonNumber(string btnValue)
        {
            if (resetClick)
            {
                //之前如按了加減乘除等按鍵,此時重新由個位數開始
                DisplayString = (btnValue == "." ? "0." : btnValue);
                resetClick = false;
            }
            else
            {
                if (DisplayString.Length < 16)  //長度要小於16
                {
                    if (btnValue == ".")  //小數點按鍵直接加在後面
                    {
                        DisplayString += btnValue;
                    }
                    else
                    {
                        //非小數點按鍵,判斷目前顯示是否為0,如果是0,則要先清除                    {
                        DisplayString = (DisplayString == "0" ? "" : DisplayString) + btnValue;
                    }
                }
            }
            return DisplayString;
        }

        //加減乘除按鍵
        public string ButtonAction(string btnAction)
        {
            string result;

            //先處理先前所設定的動作
            if (preAction == "")
            {
                //如果之前未有任何加減乘除動作,則將目前顯示的值,放入predata
                preData = double.Parse(DisplayString);
                result = DisplayString;
            }
            else
            {
                //如果之前有任何加減乘除動作,則先計算,放入計算結果
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

            //處理目前所按的動作鍵
            //等號
            if (btnAction == "=")
            {
                preAction = "";
                DisplayString = result;
            }
            else
            {
                //加減乘除
                preAction = btnAction;
            }
            resetClick = true;
            return result;
        }

        //Memory的處理
        public string MemoryHandle(string type)
        {
            switch (type)
            {
                case "c":
                    this.memory = 0;
                    isVisibleMemoryLabel = false;
                    break;

                case "r":
                    if (isVisibleMemoryLabel)
                    {
                        this.DisplayString = this.memory.ToString();
                    }

                    break;

                case "s":
                    this.memory = double.Parse(this.DisplayString);
                    isVisibleMemoryLabel = true;
                    break;

                case "+":
                    this.memory += double.Parse(this.DisplayString);
                    isVisibleMemoryLabel = true;
                    break;

                case "-":
                    this.memory -= double.Parse(this.DisplayString);
                    isVisibleMemoryLabel = true;
                    break;
            }
            resetClick = true;
            return this.DisplayString;
        }

        //特殊按鍵處理
        public string ButtonSpecial(String type)
        {
            string temp;
            switch (type)
            {
                case "<":
                    if (!resetClick)
                    {
                        temp = this.DisplayString.Substring(0, this.DisplayString.Length - 1);
                        this.DisplayString = (temp == "" || temp == "-" || temp == "-0" ? "0" : temp);
                    }
                    break;

                case "n":
                    this.DisplayString = (double.Parse(this.DisplayString) * (-1)).ToString();
                    break;

                case "v":

                    if (double.Parse(this.DisplayString) < 0)
                    {
                        resetClick = true;
                    }
                    this.DisplayString = Math.Sqrt(double.Parse(this.DisplayString)).ToString();
                    break;

                case "%":
                    this.DisplayString = (double.Parse(this.DisplayString) / (100)).ToString();
                    break;

                case "d":
                    this.DisplayString = (1 / double.Parse(this.DisplayString)).ToString();
                    break;
            }
            return this.DisplayString;
        }
    }
}