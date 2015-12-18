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
        private int[][] numbers = new int[5040][];
        private bool[] isChecked = new bool[5040];
        private int howManaytimes = 10000;
        private int[] randomNumber = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private FileInfo finfo;
        private StreamWriter sw;
        private StreamReader sr;

        public int HowManaytimes
        {
            get
            {
                return howManaytimes;
            }

            set
            {
                howManaytimes = value;
            }
        }

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

        public void Reset()
        {
            for (int i = 0; i < isChecked.Length; i++)
                isChecked[i] = false;
        }

        public int[] GenerateAnswerNumber()
        {
            Random random = new Random();

            for (int i = 0; i < this.randomNumber.Length; i++)
            {
                int idx = random.Next(i, 10);
                int tmp = this.randomNumber[i];
                this.randomNumber[i] = this.randomNumber[idx];
                this.randomNumber[idx] = tmp;
            }

            int[] answer = this.randomNumber.OrderBy(x => random.Next()).Take(4).ToArray();
            //int[] answer = Enumerable.Range(0, 10).OrderBy(x => random.Next()).Take(4).ToArray();

            return answer;
        }

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

        public void Start()
        {
            int count = 0;
            int countGuessTimes;
            int[] answer;
            int[] guessCode;
            int[] returnAnswerArray;

            while (count <= this.howManaytimes)
            {
                count++;
                countGuessTimes = 0;
                Reset();
                answer = GenerateAnswerNumber();
                while (true)
                {
                    countGuessTimes++;
                    guessCode = GetGuessCode();
                    returnAnswerArray = Compare(guessCode, answer);
                    if (returnAnswerArray[0] == 4 && returnAnswerArray[1] == 0)
                        break;
                    DeleteNumber(guessCode, returnAnswerArray);
                }
            }
            //output
        }

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

        public void DeleteNumber(int[] guess, int[] returnAnswerArray)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!isChecked[i] && !IsMatch(guess, this.numbers[i], returnAnswerArray))
                    isChecked[i] = true;
            }
        }

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

        public Boolean IsNotDuplicate(int[] c)
        {
            int[] q = c.Distinct().ToArray();
            return (q.Length == 4 ? true : false);
        }

        public bool IsCorrectLength(string[] c)
        {
            return c.Length == 4 ? true : false;
        }

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

        public void FileCreate()
        {
            finfo = new FileInfo("guess.log");
            sw = finfo.CreateText();
        }

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

        public void CloseFileInput()
        {
            this.sw.Close();
        }

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
                //temp = data.Select(x => x.ToString()).ToArray();
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