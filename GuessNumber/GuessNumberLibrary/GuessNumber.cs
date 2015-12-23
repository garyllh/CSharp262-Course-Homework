using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberLibrary
{
    public class GuessNumber
    {
        private int[][] numbers = new int[5040][];  //記錄所有數字
        private bool[] isChecked = new bool[5040];  //判斷 numbers 陣列的數字是否已經檢查過(true:已用過,false:未使用)
        public int HowManytimes { get; set; } = 10000;   //預設執行次數(for computer guess)
        private int[] randomNumber = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  //給亂數取用的array

        //log檔案處理變數(for computer guess,windows form type)
        private FileInfo finfo;

        private StreamWriter sw;
        private StreamReader sr;

        //將array 填滿所有數字(for computer guess)
        public void Init()
        {
            int count = 0;
            for (int i = 0; i <= 9; i++)
                for (int j = 0; j <= 9; j++)
                {
                    if (j == i) continue;
                    for (int k = 0; k <= 9; k++)
                    {
                        if (k == j || k == i)
                            continue;
                        for (int l = 0; l <= 9; l++)
                        {
                            if (l == k || l == j || l == i)
                                continue;
                            numbers[count] = new int[] { i, j, k, l };
                            count++;
                        }
                    }
                }
        }

        //將判斷的 array 全部改成 false (for computer guess)
        public void Reset()
        {
            for (int i = 0; i < isChecked.Length; i++)
                isChecked[i] = false;
        }

        //產生題目答案4個數字
        public int[] GenerateAnswerNumber()
        {
            Random random = new Random();

            //將randomNumber打亂(此目的是因為由亂數取的數字,發現會有連續重複的情況)
            for (int i = 0; i < this.randomNumber.Length; i++)
            {
                int idx = random.Next(i, 10);
                int tmp = this.randomNumber[i];
                this.randomNumber[i] = this.randomNumber[idx];
                this.randomNumber[idx] = tmp;
            }

            //從randomNumber 取出 4個數字
            int[] answer = this.randomNumber.OrderBy(x => random.Next()).Take(4).ToArray();

            return answer;
        }

        //取得要猜的數字(由 numbers中取出一個)(for computer)
        public int[] GetGuessCode()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!isChecked[i])
                {
                    isChecked[i] = true;
                    return numbers[i];
                }
            }
            return null;
        }

        //猜的數字與答案比較,回傳一個array,[0]:A的數字,[1]:B的數字
        public int[] Compare(int[] guess, int[] answer)
        {
            int[] returnAnswerArray = new int[2];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (guess[j] == answer[i])
                    {
                        if (i == j)
                            returnAnswerArray[0]++;
                        else
                            returnAnswerArray[1]++;
                    }
                }
            }
            return returnAnswerArray;
        }

        //將所有未檢查過的數字中,去除與猜測數字同樣AB值得數字(for computer)
        public void DeleteNumber(int[] guess, int[] returnAnswerArray)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!isChecked[i] && !IsMatch(guess, this.numbers[i], returnAnswerArray))
                    isChecked[i] = true;
            }
        }

        //比較單一數字與猜測數字,是否同樣AB值
        public bool IsMatch(int[] guess, int[] number, int[] returnAnswerArray)
        {
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (guess[i] == number[j])
                    {
                        if (i == j)
                            countA++;
                        else
                            countB++;
                        break;
                    }
                }
            }
            return (returnAnswerArray[0] == countA && returnAnswerArray[1] == countB);
        }

        //判斷是否有相同數字出現(for human,console type)
        public Boolean IsNotDuplicate(int[] c)
        {
            int[] q = c.Distinct().ToArray();
            return (q.Length == 4 ? true : false);
        }

        //判斷輸入長度是否為4(for human,console type)
        public bool IsCorrectLength(string[] c)
        {
            return c.Length == 4 ? true : false;
        }

        //判斷是否為數字(for human,console type)
        public int[] IsNumber(string[] c)
        {
            int[] returnIntArray = new int[4];
            for (int i = 0; i < c.Length; i++)
            {
                int tmp;
                if (int.TryParse(c[i], out tmp))
                {
                    returnIntArray[i] = tmp;
                }
                else
                {
                    return null;
                }
            }
            return returnIntArray;
        }

        //log存檔(for computer,windows form type)
        //開檔
        public void FileCreate()
        {
            finfo = new FileInfo("guess.log");
            sw = finfo.CreateText();
        }

        //寫檔(格式 G00001,1,1234,1A1B)
        public void WriteLog(int questionno, int serialno, int[] guess, int[] result)
        {
            string data = "";
            string temp = "00000" + questionno;
            data += "G" + temp.Substring(temp.Length - 5) + ",";
            data += serialno + ",";
            data += string.Join("", guess) + ",";
            data += result[0] + "A" + result[1] + "B";

            this.sw.WriteLine(data);
        }

        //關檔
        public void CloseFileInput()
        {
            this.sw.Close();
        }

        //讀取檔案資料(回傳 Arraylist)
        public ArrayList ReadLog(string question)
        {
            this.sr = new StreamReader("guess.log");
            string data;
            string[] temp;
            ArrayList myAL = new ArrayList();

            do
            {
                data = this.sr.ReadLine();

                if (data == null) break;
                temp = data.Split(',');
                if (temp[0] == ("G" + question))
                {
                    myAL.Add(temp);
                }
                else
                {
                    if (myAL.Count != 0)
                    {
                        break;
                    }
                }
            } while (true);

            this.sr.Close();
            return myAL;
        }
    }
}