using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {       
        static List<int> transform(List <int> A)
        {
            List <int> Clist = new List<int>();
            int k = 0;
            for (int i = 0; i < A.Count; i++)
            {              
                for (int j = 0; j <= A.Count - i - 1; j++)
                {
                    k = i + j;
                    int Temp = 0;
                    for (int t = i; t <= k; t++)
                    {
                        if (Temp < A[t])
                            Temp = A[t];
                    }
                    Clist.Add(Temp);
                }                
            }
            return Clist;
        }
        public static Boolean TransformTransform(int [] A, int N)
        {
            bool Result = false;
            int Sum = 0;
            List <int> Alist = new List<int>();
            List <int> Blist = new List<int>();
            for (int i = 0; i < N; i++)
                Alist.Add(A[i]);
            Blist = transform(Alist);          
            Blist = transform(Blist);            
            for (int i = 0; i < Blist.Count; i++)
                Sum = Sum + Blist[i];
            if (Sum % 2 == 0 && Sum > 0)
                Result = true;
            return Result;
        }
    }
}
