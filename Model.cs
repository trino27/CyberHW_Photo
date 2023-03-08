using System;
using System.Collections.Generic;
using System.Text;

namespace CyberHW_Photo
{
    class Model
    {
        public string CalcBill(int price, int num)
        {
            return Convert.ToString(price*num);
        }
        public bool IsInputCorrect(string input)
        {
            foreach(char i in input)
            {
                if (!IsNumAllow(i)) return false;
            }
            return true;
        }
        public bool IsNumAllow(char input)
        {
            if (input < 48 || input > 57) return false;
            return true;
        }
    }
}
