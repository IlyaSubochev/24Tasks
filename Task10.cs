using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string BigMinus(string s1, string s2)
        {
            string res = "";
            string ResT = "";
            double a;
            double b;
            char[] Str1 = s1.ToCharArray();
            a = Convert.ToDouble(s1);
            b = Convert.ToDouble(s2);
            if (a <= 2147483647 && b <= 2147483647)
            {
                int c = Convert.ToInt32(s1);
                int d = Convert.ToInt32(s2);
                int result = c - d;
                if (result < 0)
                    result = -result;
                res = Convert.ToString(result);
            }
            else if (a > 2147483647 && b <= 2147483647)
            {
                string s2Res = s2.Substring(s1.Length);
                int c = Convert.ToInt32(s1);
                int d = Convert.ToInt32(s2Res);
                int result = d - c;
                ResT= Convert.ToString(result);
                res = s2.Remove(s2.Length-s1.Length);
                res = res.Insert(res.Length, ResT);
            }
            return res;
        }
    }
}
