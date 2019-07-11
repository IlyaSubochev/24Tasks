using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int HowManyTimes(string s, string s_generic)
        {
            int k = 0;
            int SeqNumber=0;
            char [] a = s.ToCharArray();
            char[] b = s_generic.ToCharArray();
            int[] c = new int[a.Length];
            if (a.Length == 1)
            {
                SeqNumber = 0;
            }
            else
            {                  
                for (int i = 0; i < a.Length; i++)
                {
                    k = 0;
                    for (int j = i; j < b.Length-a.Length+i+1; j++)
                    {
                        if (a[i] == b[j])
                            k++;                      
                    }
                    c[i]= k;
                }
            }
            bool SeqFlag = true;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] == a[j])
                        SeqFlag = false;

            if (c.Length == 2 && a[0] == a[1])
            {
                SeqNumber = (c[0] - c[1]) * c[1];
            }
            else if (c.Length == 2)
                SeqNumber = c[0] * c[1];

            else if (c[0] * c[1] <= c[c.Length - 1] * c[c.Length - 2] || SeqFlag==true)
            {
                SeqNumber = 1;
                for (int i = 0; i < c.Length; i++)
                    SeqNumber = SeqNumber * c[i];
            }
            else if (c[0] * c[1] > c[c.Length - 1] * c[c.Length - 2] && a.Length<3)
            {
                for (int i = 0; i < c.Length; i = i + 2)
                {
                    if (i < 1)
                    {
                        SeqNumber = (c[i] - c[i + 1]) * c[i + 1];
                    }
                    else
                        SeqNumber = SeqNumber * c[i];
                }
            } 
            return SeqNumber;
        }
    }
}
