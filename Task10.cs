using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] ArrConvert(string s)
        {
            int[] Arr = new int[2];                           
            Arr[0] = Convert.ToInt32(s.Substring(0,s.Length - s.Length / 2));
            Arr[1] = Convert.ToInt32(s.Substring(s.Length - s.Length / 2));
            return Arr;
        }
        public static string BigMinus(string s1, string s2)
        {
            string res = "";
            char[] Str1 = s1.ToCharArray();
            char[] Str2 = s2.ToCharArray();          
            if (s1.Equals(s2) == true)
                res = "0";
            else if (s1.Length < 10 && s2.Length < 10)
            {
                int a = Convert.ToInt32(s1);
                int b = Convert.ToInt32(s2);
                int result = a - b;
                if (result < 0)
                    result = -result;
                res = Convert.ToString(result);
            }
            else if (s1.Length >= 10 && s2.Length >= 10)
            {
                int[] ArrS1 = ArrConvert(s1);
                int[] ArrS2 = ArrConvert(s2);
                int[] ArrRes = new int[2];
                if (ArrS1.Length == ArrS2.Length)
                {
                    for (int i = ArrS2.Length - 1; i >= 0; i--)
                    {
                        ArrRes[i] = ArrS1[i] - ArrS2[i];
                    }
                    for (int i = ArrRes.Length - 1; i >= 0; i--)
                    {
                        if (ArrRes[i] < 0)
                        {
                            ArrRes[i] = -ArrRes[i];
                        }
                    }
                }
                for (int i = 0; i < ArrRes.Length; i++)
                {
                    int t = ArrRes[i];
                    res = res + Convert.ToString(t);
                }
                if (s1.Length > s2.Length)
                {
                    while (res.Length != s1.Length)
                        res = res.Insert(res.Length, "0");
                }
                else
                {
                    while (res.Length != s2.Length)
                        res = res.Insert(res.Length, "0");
                }
            }
            else if (s1.Length >= 10 && s2.Length < 10)
            {
                int[] ArrS1 = ArrConvert(s1);
                int[] ArrRes = new int[2];
                if ((s1.Length / 2) >= s2.Length)
                {
                    int ArrS2 = Convert.ToInt32(s2);
                    ArrRes[0] = ArrS1[0];
                    ArrRes[1] = ArrS1[1] - ArrS2;
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        int t = ArrRes[i];
                        res = res + Convert.ToString(t);
                    }
                }
                else
                {
                    int[] ArrS2 = new int[2];
                    ArrS2[0] = Convert.ToInt32(s2.Substring(0, s2.Length - s1.Length / 2));
                    ArrS2[1] = Convert.ToInt32(s2.Substring(s2.Length - s1.Length / 2));
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        ArrRes[i] = ArrS1[i] - ArrS2[i];
                    }
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        if (ArrRes[i] < 0)
                        {
                            ArrRes[i] = -ArrRes[i];
                        }
                    }
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        int t = ArrRes[i];
                        res = res + Convert.ToString(t);
                    }
                    while (res.Length != s1.Length)
                        res = res.Insert(res.Length, "0");

                }
            }
            else if (s2.Length >= 10 && s1.Length < 10)
            {
                int[] ArrS2 = ArrConvert(s2);
                int[] ArrRes = new int[2];
                if ((s2.Length / 2) >= s1.Length)
                {
                    int ArrS1 = Convert.ToInt32(s1);
                    ArrRes[0] = ArrS2[0];
                    ArrRes[1] = ArrS2[1] - ArrS1;
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        int t = ArrRes[i];
                        res = res + Convert.ToString(t);
                    }
                }
                else
                {
                    int[] ArrS1 = new int[2];
                    ArrS1[0] = Convert.ToInt32(s1.Substring(0, s1.Length - s2.Length / 2));
                    ArrS1[1] = Convert.ToInt32(s1.Substring(s1.Length - s2.Length / 2));
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        ArrRes[i] = ArrS2[i] - ArrS1[i];
                    }
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        if (ArrRes[i] < 0)
                        {
                            ArrRes[i] = -ArrRes[i];
                        }
                    }
                    for (int i = 0; i < ArrRes.Length; i++)
                    {
                        int t = ArrRes[i];
                        res = res + Convert.ToString(t);
                    }
                    while (res.Length != s2.Length)
                        res = res.Insert(res.Length, "0");
                }
            }
            return res;
        }
    }
}
