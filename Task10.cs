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
            string test = "2147483647";
           
            char[] Str1 = s1.ToCharArray();
            
            Console.WriteLine(test.Length);
            if (s1.Length < 10 && s2.Length < 10)
            {
                int a = Convert.ToInt32(s1);
                int b = Convert.ToInt32(s2);
                int result = a - b;
                if (result < 0)
                    result = -result;
                res = Convert.ToString(result);
            }
            
            //if (a == b)
            //    res = "0";
            //else if (a <= 2147483647 && b <= 2147483647)
            //{
            //    int c = Convert.ToInt32(s1);
            //    int d = Convert.ToInt32(s2);
            //    int result = c - d;
            //    if (result < 0)
            //        result = -result;
            //    res = Convert.ToString(result);
            //}
            //else if (a > 2147483647 && b <= 2147483647)
            //{
            //    string s2Res = s2.Substring(s1.Length);
            //    int c = Convert.ToInt32(s1);
            //    int d = Convert.ToInt32(s2Res);
            //    int result = c - d;
            //    if (result < 0)
            //        result = -result;
            //    ResT = Convert.ToString(result);
            //    res = s2.Remove(s2.Length - s1.Length);
            //    res = res.Insert(res.Length, ResT);
            //}
            //else if (b > 2147483647 && a <= 2147483647)
            //{
            //    string s2Res = s1.Substring(s2.Length);
            //    int c = Convert.ToInt32(s1);
            //    int d = Convert.ToInt32(s2Res);
            //    int result = c - d;
            //    if (result < 0)
            //        result = -result;
            //    ResT = Convert.ToString(result);
            //    res = s2.Remove(s2.Length - s1.Length);
            //    res = res.Insert(res.Length, ResT);
            //}
            //else if (a > 2147483647 && b > 2147483647 && a>b)
            //{
            //    res = "dads";
            //}

            return res;
        }
    }
}
