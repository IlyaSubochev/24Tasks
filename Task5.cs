using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string PatternUnlock(int N, int[] hits)
        {
            double sum = 0;
            for (int i = 0; i < N - 1; i++)
            {
                //1
                if (hits[i] == 1 && (hits[i + 1] == 6 || hits[i + 1] == 9 || hits[i + 1] == 2))
                    sum = sum + 1;
                else if (hits[i] == 1 && (hits[i + 1] == 5 || hits[i + 1] == 8))
                    sum = sum + 1.41421;
                //2
                else if (hits[i] == 2 && (hits[i + 1] == 5 || hits[i + 1] == 8 || hits[i + 1] == 3 || hits[i + 1] == 1))
                    sum = sum + 1;
                else if (hits[i] == 2 && (hits[i + 1] == 6 || hits[i + 1] == 9 || hits[i + 1] == 4 || hits[i + 1] == 7))
                    sum = sum + 1.41421;
                //3
                else if (hits[i] == 3 && (hits[i + 1] == 4 || hits[i + 1] == 7 || hits[i + 1] == 2))
                    sum = sum + 1;
                else if (hits[i] == 3 && (hits[i + 1] == 5 || hits[i + 1] == 8))
                    sum = sum + 1.41421;
                //4
                else if (hits[i] == 4 && (hits[i + 1] == 5 || hits[i + 1] == 3))
                    sum = sum + 1;
                else if (hits[i] == 4 && hits[i + 1] == 2)
                    sum = sum + 1.41421;
                //5
                else if (hits[i] == 5 && (hits[i + 1] == 2 || hits[i + 1] == 4 || hits[i + 1] == 6))
                    sum = sum + 1;
                else if (hits[i] == 5 && (hits[i + 1] == 1 || hits[i + 1] == 3))
                    sum = sum + 1.41421;
                //6
                else if (hits[i] == 6 && (hits[i + 1] == 1 || hits[i + 1] == 5))
                    sum = sum + 1;
                else if (hits[i] == 6 && hits[i + 1] == 2)
                    sum = sum + 1.41421;
                //7
                else if (hits[i] == 7 && (hits[i + 1] == 3 || hits[i + 1] == 8))
                    sum = sum + 1;
                else if (hits[i] == 7 && hits[i + 1] == 2)
                    sum = sum + 1.41421;
                //8
                else if (hits[i] == 8 && (hits[i + 1] == 2 || hits[i + 1] == 9 || hits[i + 1] == 7))
                    sum = sum + 1;
                else if (hits[i] == 8 && (hits[i + 1] == 1 || hits[i + 1] == 3))
                    sum = sum + 1.41421;
                //9
                else if (hits[i] == 9 && (hits[i + 1] == 1 || hits[i + 1] == 8))
                    sum = sum + 1;
                else if (hits[i] == 9 && hits[i + 1] == 2)
                    sum = sum + 1.41421;
            }
            String s = Convert.ToString(sum);
            s = s.Replace(".", "");
            s = s.Replace("0", "");
            s = s.Replace(",", "");
            return s;
        }
    }
}
