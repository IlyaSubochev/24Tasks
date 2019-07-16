using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string[] ShopOLAP(int N, string[] items)
        {
            string[] ResItems = new string[N];
            int flag = 0;
            Array.Sort(items);
            for (int i = 0; i < N; i++)
            {
                bool Temp = false;
                for (int j = i + 1; j < N; j++)
                {

                    if (i < N - 1 && items[i].Split(' ')[0] == items[j].Split(' ')[0] && Temp == false)
                    {
                        ResItems[i] = items[i].Split(' ')[0] + ' '
                        + Convert.ToString(Convert.ToInt32(items[i].Split(' ')[1]) + Convert.ToInt32(items[j].Split(' ')[1]));
                        Temp = true;
                    }
                    else if (i < N - 1 && items[i].Split(' ')[0] == items[j].Split(' ')[0] && Temp == true)
                    {
                        ResItems[i] = items[i].Split(' ')[0] + ' '
                        + Convert.ToString(Convert.ToInt32(items[j].Split(' ')[1]) + Convert.ToInt32(ResItems[i].Split(' ')[1]));
                    }
                    else if (i < N - 1 && items[i].Split(' ')[0] != items[j].Split(' ')[0] && Temp == false)
                        ResItems[i] = items[i];
                }
                if (i == (N - 1))
                    ResItems[i] = items[i];
            }
            for (int i = 0; i < ResItems.Length - 1; i++)
            {
                if (items[i].Split(' ')[0] == items[i + 1].Split(' ')[0])
                    ResItems[i + 1] = "0";
            }
            for (int i = 0; i < ResItems.Length; i++)
            {
                if (ResItems[i] == "0")
                    flag++;
            }
            string[] ResultItems = new string[ResItems.Length - flag];
            int k = 0;
            for (int i = 0; i < ResultItems.Length; i++)
            {
                for (int j = i + k; j < ResItems.Length; j++)
                {
                    if (ResItems[j] == "0")
                    {
                        k++;
                        continue;
                    }
                    else if (i > 0 && ResItems[j] != ResultItems[i - 1])
                    {
                        ResultItems[i] = ResItems[j];
                        break;
                    }
                    else
                    {
                        ResultItems[i] = ResItems[j];
                        break;
                    }
                }
            }
            return ResultItems;
        }
    }
}
