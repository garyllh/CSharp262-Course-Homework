using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class TicketDiscountNameList
    {
        public ArrayList GetChildDiscountList()
        {
            string temp = "0,無折扣";
            temp += "|" + "1,小朋友如果年齡在10周歲及以下的兒童3折";
            temp += "|" + "2,小學生與屁孩7折優惠";

            return JaggedArray(temp);
        }

        public ArrayList GetStudentDiscountList()
        {
            string temp = "0,無折扣";
            temp += "|" + "1,學生憑學生證可享受票價8折優惠";
            temp += "|" + "2,學生憑學生證女生可享受票價7.5折優惠";

            return JaggedArray(temp);
        }

        public ArrayList GetVipDiscountList()
        {
            string temp = "0,無折扣";
            temp += "|" + "1,持花旗卡可以半價，並可累積點數，另外累積點數夠多，還可以換贈品";
            temp += "|" + "2,持 A 卡可以八折";
            temp += "|" + "3,持 B 卡可以六折";

            return JaggedArray(temp);
        }

        public IDiscount SelectDiscount(int type, string discountNo)
        {
            if (type == 0)  //全票
            {
                switch (discountNo)
                {
                    case "1":
                        return new Vip01();

                    case "2":
                        return new Vip02();

                    case "3":
                        return new Vip03();

                    default:
                        return new Vip00();
                }
            }
            else if (type == 1)  //學生票
            {
                switch (discountNo)
                {
                    case "1":
                        return new Student01();

                    case "2":
                        return new Student02();

                    default:
                        return new Student00();
                }
            }
            else   //兒童票
            {
                switch (discountNo)
                {
                    case "1":
                        return new Children01();

                    case "2":
                        return new Children02();

                    default:
                        return new Children00();
                }
            }
            //(IDiscount discount
            return null;
        }

        public ArrayList JaggedArray(string idname)
        {
            ArrayList list = new ArrayList();
            string[] tempArray, tempArray2;
            tempArray = idname.Split('|');
            foreach (string value in tempArray)
            {
                if (value != "")
                {
                    tempArray2 = value.Split(',');
                    list.Add(tempArray2);
                }
            }
            return list;
        }
    }
}