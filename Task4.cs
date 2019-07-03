using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] ArrSort(int[] a)
        {
            int temp = 0;
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                b[i] = a[i];
            for (int i = 0; i < a.Length; i++)
                for (int j = i; j < a.Length; j++)
                {
                    if (b[i] > b[j])
                    {
                        temp = b[j];
                        b[j] = b[i];
                        b[i] = temp;
                    }
                }
            return b;
        }
        public static int[] SynchronizingTables(int N, int[] ids, int[] salary)
        {
            int[] TempIds = new int[N];
            int[] TempSalary = new int[N];
            int[] FixSalary = new int[N];
            TempIds = ArrSort(ids);
            TempSalary = ArrSort(salary);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (ids[i] == TempIds[j])
                        FixSalary[i] = TempSalary[j];         
            return FixSalary;
        }
    }
}
