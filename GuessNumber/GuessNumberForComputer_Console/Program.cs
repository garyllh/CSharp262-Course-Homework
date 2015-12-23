using GuessNumberLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberForComputer_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string retry;
            int inputGuessTimes;
            string temp;

            int count = 0;  //目前執行到第幾題
            int countGuessTimes;
            int[] answer;
            int[] guess;
            int[] returnAnswerArray;

            int sumEachGuessTimes;  //記錄每題猜的次數

            GuessNumber objectGN = new GuessNumber();
            objectGN.HowManytimes = 10000;
            objectGN.Init();

            while (true)  //for 重玩所使用的迴圈
            {
                count = 0;
                sumEachGuessTimes = 0;

                Console.Clear();
                Console.WriteLine("猜數字遊戲(2)電腦自己出題及猜題!!! \n\n遊戲開始.......................\n");

                // Console.WriteLine("---- 電腦自己出題及猜題!!! \n\n遊戲開始.......................\n");
                Console.Write("請輸入執行次數(預設次數 = {0} ):", objectGN.HowManytimes);

                temp = Console.ReadLine();
                if (temp != "")
                    if (int.TryParse(temp, out inputGuessTimes))
                    {
                        objectGN.HowManytimes = inputGuessTimes;
                    }
                    else
                    {
                        Console.WriteLine("\nError!輸入資料錯誤,請按任意鍵重新開始...");
                        Console.ReadKey();
                        continue;
                    }

                while (count < objectGN.HowManytimes)  //執行的迴圈
                {
                    count++;
                    countGuessTimes = 0;
                    objectGN.Reset();
                    answer = objectGN.GenerateAnswerNumber();
                    Console.WriteLine("\n第{0}次-題目答案: {1}", count, string.Join("", answer));
                    while (true)
                    {
                        countGuessTimes++;
                        guess = objectGN.GetGuessCode();
                        returnAnswerArray = objectGN.Compare(guess, answer);
                        Console.WriteLine("Ans{0}: {1} => {2} A {3} B",
                            countGuessTimes,
                            string.Join("", guess),
                            returnAnswerArray[0],
                            returnAnswerArray[1]);
                        if (returnAnswerArray[0] == 4 && returnAnswerArray[1] == 0)
                        {
                            //猜到
                            sumEachGuessTimes += countGuessTimes;
                            break;
                        }
                        objectGN.DeleteNumber(guess, returnAnswerArray);
                    }
                }
                //output

                Console.WriteLine("\n執行 {0} 題,平均每題使用 {1} 次", objectGN.HowManytimes, ((float)sumEachGuessTimes / (float)objectGN.HowManytimes));

                Console.WriteLine("\n重新玩一次(y/n)?");
                retry = Console.ReadLine();
                if (retry.ToUpper() != "Y")
                    break;
            }
        }
    }
}