using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int odometer(int[] oksana)
        {
            int n = 0;
            if (oksana.Length % 2 == 0)
                n = oksana.Length;
            else
                n = oksana.Length - 1;
            int sum = 0;
            for (int i = 0; i < n; i=i+2)
            {
                if (i==0)
                    sum = sum + oksana[i] * oksana[i + 1];
                else
                    sum = sum + oksana[i] * (oksana[i + 1] - oksana[i - 1]);
            }    
            return sum;
        }
    }
}
