using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {      
        public static void MatrixTurn(string [] Matrix, int M, int N, int T)
        {
            int[,] Result = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Result[i, j] = Convert.ToInt32(Matrix[i].Substring(j, 1));
                }
            }         
            int[,] Result2 = new int[M, N];
            int n = 0;
            int k = 0;
            while (k < T)
            {
                while (n < M / 2)
                {
                    for (int i = n; i < M - n; i++)
                    {
                        for (int j = n; j < N - n; j++)
                        {
                            if (i - n == 0 && j + n < N - 1)
                                Result2[i, j + 1] = Result[i, j];
                            else if (j + n == N - 1 && i - n == 0)
                                Result2[i + 1, j] = Result[i, j];
                            else if (j + n == N - 1 && i + n == M - 1)
                                Result2[i, j - 1] = Result[i, j];
                            else if (j + n == 0 && i + n == M - 1)
                                Result2[i - 1, j] = Result[i, j];
                            else if (j + n == N - 1 && i + n < M - 1 && i + n > 0)
                                Result2[i + 1, j] = Result[i, j];
                            else if (i + n == M - 1 && j + n < N && j - n > 0)
                                Result2[i, j - 1] = Result[i, j];
                            else if (j - n == 0 && i - n > 0 && i + n < M)
                                Result2[i - 1, j] = Result[i, j];
                        }
                    }
                    n++;
                }
                k++;
            }
            Array.Clear(Matrix, 0, M);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Matrix[i] = Matrix[i] + Convert.ToString(Result2[i, j]);
                }
            }
        }
    }
}
