using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int MaximumDiscount(int N, int[] price)
        {
            int MaxDiscount = 0;
            int temp = 0;
            int[] SortPrice = new int[N];
            for (int i = 0; i < N; i++)            
                SortPrice[i] = price[i];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (SortPrice[j] < SortPrice[i])
                    {
                        temp = SortPrice[j];
                        SortPrice[j] = SortPrice[i];
                        SortPrice[i] = temp;
                    }
                }
            }
            int k = 0;
            while (k < 3*(N/3))
            {
                if (k == 0)
                {
                    MaxDiscount = MaxDiscount + SortPrice[k + 2];
                    k = k + 2;
                }
                else if ((k+3)<N)
                {
                    MaxDiscount = MaxDiscount + SortPrice[k + 3];
                    k = k + 3;
                }
                else
                    k = k + 3;
            }
            return  MaxDiscount;
            ;
        }
    }
}
