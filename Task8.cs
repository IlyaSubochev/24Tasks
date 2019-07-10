using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int HowManyTimes(string s, string s_generic)
        {
            int SeqNumber = 1;
            char [] a = s.ToCharArray();
            char[] b = s_generic.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        k++;
                }
                SeqNumber = k * SeqNumber;
            }
            return SeqNumber;
        }
    }
}
