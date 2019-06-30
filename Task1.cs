using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int Squirrel(int N)
        {
            int n = 0;
            if (N == 0)
            {
                n = 1;
            }
            else
            { 
                double k = 1;
                for (int i = 1; i <= N; i++)
                    k = i * k;  
                if (double.IsInfinity(k)) 
                return n;
                else
                {
                    while (k > 1)
                    {
                        if (k <= 2147483647)
                        {
                            n = (int)k;
                            k = k / 10;
                        }
                        else k = k / 10;
                    }
                }
            }
            return n;
        }
    }
}
