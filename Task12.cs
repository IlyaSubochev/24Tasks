using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] UFO(int N, int[] data, bool octal)
        {
            int[] res = new int[N];
            if (octal == true)
            {
                for (int i = 0; i < N; i++)
                {
                    int TempData = data[i];
                    string a = Convert.ToString(data[i]);

                    for (int j = 0; j < a.Length; j++)
                    {
                        int t = 1;
                        int tt = TempData % 10;
                        if (j == 0)
                            t = 1;
                        else
                        {
                            for (int k = 0; k < j; k++)
                                t = t * 8;
                        }
                        res[i] = res[i] + t * tt;
                        TempData = TempData / 10;
                    }
                }
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    int TempData = data[i];
                    string a = Convert.ToString(data[i]);

                    for (int j = 0; j < a.Length; j++)
                    {
                        int t = 1;
                        int tt = TempData % 10;
                        if (j == 0)
                            t = 1;
                        else
                        {
                            for (int k = 0; k < j; k++)
                                t = t * 16;
                        }
                        res[i] = res[i] + t * tt;
                        TempData = TempData / 10;
                    }
                }
            }
            return res;
        }
    }
}
