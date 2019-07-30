using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {
        static int MaxT(int[] C, int k, int i)
        {
            int Temp = C[i];             
            for ( ; i <= k; i++)
            {
                if (Temp < C[i])
                    Temp = C[i];                
            }
            return Temp;
        }
        static int[] transform(int[] C)
        {
            int [] D = new int[C.Length];
            int k = 0;
            for (int i = 0; i < C.Length; i++)
            {
                int Temp = 0;
                for (int j = 0; j <= C.Length - i - 1; j++)
                {
                    k = i + j;
                    Temp = MaxT(C, k, i);
                }
                D[D.Length  - i - 1] = Temp;
            }
            return D;
        }
        public static Boolean TransformTransform(int [] A, int N)
        {
            bool Result = false;
            int Sum = 0;
            int[] B = new int[A.Length];
            B = transform(A);           
            B = transform(B);          
            for (int i = 0; i < B.Length; i++)
                Sum = Sum + B[i];
            if (Sum % 2 == 0)
                Result = true;
            return Result;
        }
    }
}
