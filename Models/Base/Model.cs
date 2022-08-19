using System;

namespace CCExchange.Models.Base
{
    public abstract class Model
    {
        protected string ConvertBig(decimal num)
        {
            bool isB = false;
            bool isM = false;
            if (num > 1000000000)
            {
                num = num / 1000000000;
                isB = true;
            }
            else if (num > 1000000)
            {
                num = num / 1000000;
                isM = true;
            }
            num = Math.Round(num, 2);
            string res = num.ToString();
            if (isB) res = res + "b";
            if (isM) res = res + "m";
            return res;
        }
    }
}
