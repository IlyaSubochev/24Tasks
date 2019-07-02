using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int Check(int[,] b)
        {
            int sum = 0;
            for (int i = 0; i < b.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                    sum = sum + b[i, j];
            return sum;
        }
        public static int [,] Transfer (int[,] a)
        {
            int[,] b = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    b [i, j] = a[i, j];
            return b;         
                }
        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
        {
            int[,] a = new int[N, M];
            int[,] res = new int[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    a[i, j] = 0;
            for (int n = 0; n < battalion.Length; n = n + 2)
            {
                int i = battalion[n];
                int j = battalion[n + 1];
                a[i - 1, j - 1] = 1;
            }
            int d = 1;
            while (Check(a) != ((N * M)))
            {
                res = Transfer(a);
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                    {
                        if (res[i, j] == 1 && i == 0 && j == 0)           //1
                        {
                            a[i + 1, j] = 1;
                            a[i, j + 1] = 1;
                        }
                        else if (res[i, j] == 1 && i == 0 && j == (M - 1))        //2  
                        {
                            a[i, j - 1] = 1;
                            a[i + 1, j] = 1;
                        }
                        else if (res[i, j] == 1 && i == (N - 1) && j == 0)          //3
                        {
                            a[i - 1, j] = 1;
                            a[i, j + 1] = 1;
                        }
                        else if (res[i, j] == 1 && i == (N - 1) && j == (M - 1))          //4
                        {
                            a[i - 1, j] = 1;
                            a[i, j - 1] = 1;
                        }
                        else if (res[i, j] == 1 && i == 0 && j > 0 && j < (M - 1))        //5
                        {
                            a[i + 1, j] = 1;
                            a[i, j + 1] = 1;
                            a[i, j - 1] = 1;
                        }
                        else if (res[i, j] == 1 && i > 0 && i < (N - 1) && j == (M - 1))        //6
                        {
                            a[i + 1, j] = 1;
                            a[i - 1, j] = 1;
                            a[i, j - 1] = 1;
                        }
                        else if (res[i, j] == 1 && i == (N - 1) && j > 0 && j < (M - 1))        //7
                        {
                            a[i - 1, j] = 1;
                            a[i, j + 1] = 1;
                            a[i, j - 1] = 1;
                        }
                        else if (res[i, j] == 1 && i > 0 && i < (N - 1) && j == 0)        //8
                        {
                            a[i + 1, j] = 1;
                            a[i - 1, j] = 1;
                            a[i, j + 1] = 1;
                        }
                        else if (res[i, j] == 1 && i > 0 && i < (N-1) && j > 0 && j < (M-1))        //9
                        {
                            a[i + 1, j] = 1;
                            a[i - 1, j] = 1;
                            a[i, j + 1] = 1;
                            a[i, j - 1] = 1;
                        }
                    }
                d++;
            }
            return d;
        }  
    }
}
