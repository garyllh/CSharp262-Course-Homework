using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary
{
    public class Booking
    {
        public int[] seatCheck = new int[59];  //0:empty,1:occupy; 2:aisle
        public string[] seatName = new string[59];
        public int[] aisle = { 4, 13, 19, 24, 33, 39, 44, 53 };

        public Booking()
        {
            int row = 1;  //row1,row2,row3
            int alphabet = 65; //ABCDEFG.....
            for (int i = 0; i < seatName.Length; i++)
            {
                if (Array.IndexOf(aisle, i) > -1)
                {
                    seatCheck[i] = 2;
                    seatName[i] = "";
                    if (i == 19 || i == 39)
                    {
                        row++;
                        alphabet = 65;
                    }
                    continue;
                }
                else
                {
                    seatCheck[i] = 0;
                    seatName[i] = row.ToString() + (char)(alphabet++); //1A,1B...,2A,2B....,3A,3B...
                }
            }
        }

        //新場次
        public void ResetSeat()
        {
            for (int i = 0; i < seatName.Length; i++)
            {
                if (Array.IndexOf(aisle, i) < 0)
                {
                    seatCheck[i] = 0;
                }
            }
        }

        //開始尋找
        public string StartSearch(int people)
        {
            string result = "";
            string temp = "";
            int count;
            for (int i = 0; i < seatCheck.Length; i++)
            {
                temp = "";
                count = people;
                if (seatCheck[i] == 0 && (seatCheck.Length - (i + 1)) >= (people - 1))
                { //empty and lenght >= people
                    count--;
                    temp = seatName[i];
                    for (int j = i + 1; j < i + people; j++)
                    {
                        if (seatCheck[j] == 0)
                        {
                            temp += ',' + seatName[j];
                            count--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (count == 0)
                        result += (result == "" ? "" : "|") + temp;
                }
            }

            return result;
        }

        public string[] FindChecked()
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < seatCheck.Length; i++)
            {
                if (seatCheck[i] == 1)
                {
                    result.Add(seatName[i]);
                }
            }

            return (string[])result.ToArray(typeof(string));
        }

        public void Booked(string[] selectSeat)
        {
            for (int i = 0; i < this.seatName.Length; i++)
            {
                if (Array.IndexOf(selectSeat, this.seatName[i]) > -1)
                    this.seatCheck[i] = 1;
            }
        }
    }
}