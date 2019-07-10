using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {       
        public static int SumOfThe(int N, int[] data)
        {
            int Sum = 0;
            int SumNumber = 0;
            for (int i = 0; i < N; i++)
            {                
                for (int j = 0; j < N; j++)
                {

                    if (j == 0)
                        Sum = 0;
                    if (i == j)
                        continue;
                    else
                        Sum = Sum + data[j];
                }
                if (data[i] == Sum)
                {
                    SumNumber = Sum;
                    break;
                }
            }
            return SumNumber;
        }
    }
}
