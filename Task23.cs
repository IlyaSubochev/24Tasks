using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {
        public static bool CheckSequense(int Start, int Stop, int[] Arr, int[] ArrSort)
        {
            bool Res = false;
            int n = Arr.Length;
            Array.Sort(Arr, Start, Stop);
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == ArrSort[i])
                    n--;
            }
            if (n == 0)
                Res = true;
            else if (Start==0 && Stop == n-1)
                Res = true;
            return Res;
        }
        public static Boolean Football(int [] F, int N)
        {
            bool Result = false;
            int[] TempF = new int[N];
            int TempF2 = 0;
            int StartIndex = 0;
            int StopIndex = 0;
            for (int i = 0; i < N; i++)
                TempF[i] = F[i];
            Array.Sort(TempF);
            if (N == 2)
                Result = true;
            else
            {
                int Temp = 0;
                for (int i = 0; i < N; i++)
                {
                    if (TempF[i] == F[i])
                        Temp++;
                }
                if (Temp == N - 2)
                    Result = true;
                TempF2=Temp;
            }
            if (Result == false && TempF2>0)
            {
                for (int i = 0; i < N; i++)
                {
                    int Tf2 = F[i];
                    int count = 0;
                    for (int j = 0; j < N; j++)
                    {
                        if (Tf2 > F[j])
                            count++;
                        if (count > 1)
                        {
                            StartIndex = i;
                            StopIndex = j;
                        }
                    }
                    if (StopIndex > 0 && Result==false && StartIndex != StopIndex)
                    {
                        Result = CheckSequense(StartIndex, StopIndex, F, TempF);
                    }
                }
            }
            return Result;
        }
    }
}
