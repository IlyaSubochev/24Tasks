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
            int[,] c = new int[a.Length,b.Length];
            int[] MemC = new int[a.Length*b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        c[i, j] = 1;
                    else
                        c[i, j] = 0;
                }
            }
            for (int j = 0; j < b.Length;j++)
            {
                if (c[k, j] == 1 && k < a.Length - 1)
                {                  
                    MemC[2 * k + 1] = j;
                    k++;
                }
                else if (k == a.Length - 1 && c[k, j] == 1)
                    SeqNumber++;                
                else if (k==0 && j == b.Length - a.Length && c[k, b.Length - a.Length] == 0)
                    break;
                if (j == b.Length - 1 && k>0)
                {
                    k = k-1;
                    j = MemC[2 * k + 1];
                }                
            }          
            return SeqNumber;
        }
    }
}
