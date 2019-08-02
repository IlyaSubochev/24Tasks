using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {       
        public static string Keymaker(int k)
        {
            string Result = " ";
            char[] a = new char[k+1];
            for (int i = 1; i < k+1; i++)
                a[i] = '1';
            for (int i = 2; i < k+1; i++)
            {
                for (int j = 1; j < k+1; j++)
                {
                    if (i * j < k + 1 && a[i * j] == '1')
                        a[i * j] = '0';
                    else if (i * j < k + 1 && a[i * j] == '0')
                        a[i * j] = '1';
                }
            }
            for (int i = 1; i < k+1; i++)
            {
                Result = Result + a[i];
            }
            return Result;
        }
    }
}
