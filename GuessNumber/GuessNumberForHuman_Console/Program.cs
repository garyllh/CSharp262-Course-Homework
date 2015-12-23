using GuessNumberLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberForHuman_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GuessNumber objectGN = new GuessNumber();
            objectGN.HowManytimes = 1;
            int[] answer;
            int countNo = 0;
            string guessString;
            string[] guessStringTemp;
            int[] guess;
            string retry;
            int[] result;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("猜數字遊戲(1)");
                Console.WriteLine("---- 請輸入4個不重複的數字(0~9),猜出電腦設定的數字 ");
                Console.WriteLine("---- 輸入0000,離開執行中的遊戲!!! \n\n遊戲開始.......................\n");
                answer = objectGN.GenerateAnswerNumber();
                countNo = 0;

                while (true)
                {
                    countNo++;
                    Console.Write("Ans({0}):", countNo);
                    guessString = Console.ReadLine();
                    if (guessString == "0000")
                    {
                        Console.WriteLine("\n正確答案:{0}\n", string.Join("", answer));
                        break;
                    }

                    //將輸入值轉成array
                    guessStringTemp = guessString.Select(x => x.ToString()).ToArray();

                    //check user input data if error
                    if (!objectGN.IsCorrectLength(guessStringTemp))
                    {
                        Console.WriteLine("Error:輸入長度不正確{0}!!\n", guessStringTemp.Length);
                        continue;
                    }

                    //IsNumber除判斷是否為數字外,並將其轉換為數字陣列
                    guess = objectGN.IsNumber(guessStringTemp);

                    if (guess == null)
                    {
                        Console.WriteLine("Error:有非數字資料!!\n");
                        continue;
                    }

                    if (!objectGN.IsNotDuplicate(guess))
                    {
                        Console.WriteLine("Error:數字有重複!!\n");
                        continue;
                    }

                    //guess starting
                    result = objectGN.Compare(guess, answer);
                    if (result[0] == 4 && result[1] == 0)
                    {
                        Console.WriteLine("\n*** 恭喜您答對了 ****\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hint: {0} A {1} B\n", result[0], result[1]);
                    }
                }
                Console.WriteLine("\n重新玩一次(y/n)?");
                retry = Console.ReadLine();
                if (retry.ToUpper() != "Y")
                    break;
            }
        }
    }
}