using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {       
        public static int[] WordSearch(int len, string s, string subs)
        {
            String Temp = "";
            bool flag = false;
            string[] ArrStringEqualize = s.Split(' ');
            string[] ArrFind = new string[len];
            for (int i = 0; i < ArrStringEqualize.Length; i++)
            {
                if ((i < ArrStringEqualize.Length - 1) && (ArrStringEqualize[i].Length + ArrStringEqualize[i + 1].Length) < len
                    && flag == false)
                {
                    ArrFind[i] = ArrStringEqualize[i] + ' ' + ArrStringEqualize[i + 1];
                    i++;
                }
                else if ((i < ArrStringEqualize.Length - 1) && (ArrStringEqualize[i].Length + ArrStringEqualize[i + 1].Length) <
                    (len - Temp.Length) && flag == true)
                {
                    ArrFind[i] = Temp + ' ' + ArrStringEqualize[i] + ' ' + ArrStringEqualize[i + 1];
                    i++;
                    Temp = "";
                    flag = false;
                }
                else if (ArrStringEqualize[i].Length < len && flag == false)
                    ArrFind[i] = ArrStringEqualize[i];
                else if (ArrStringEqualize[i].Length < (len - Temp.Length) && flag == true)
                {
                    ArrFind[i] = Temp + ' ' + ArrStringEqualize[i];
                    Temp = "";
                    flag = false;
                }
                else if (ArrStringEqualize[i].Length > len)
                {
                    ArrFind[i] = ArrStringEqualize[i].Substring(0, len - 1);
                    Temp = ArrStringEqualize[i].Substring(len - 1, ArrStringEqualize[i].Length - len + 1);
                    flag = true;
                }
                else
                    ArrFind[i] = ArrStringEqualize[i];
            }
            int k = 0;
            for (int i = 0; i < ArrFind.Length; i++)
            {
                if (ArrFind[i] == null)
                     k++;          
            }
            string[] ArrFindFix = new string[ArrFind.Length-k];
            int t = 0;
            for (int i = 0; i < ArrFindFix.Length; i++)
            {
                for (int j = t; j < ArrFind.Length; j++)
                {
                    if (ArrFind[j] != null)
                    {
                        ArrFindFix[i] = ArrFind[j];
                        t = j+1;
                        break;
                    } 
                }
            }
            int[] Sequence = new int[ArrFindFix.Length];
            for (int i = 0; i < Sequence.Length; i++)
            {
                string s1 = ArrFindFix[i];
                bool n = s1.Contains(subs);
                if (n==true)
                {
                    char[] a = ArrFindFix[i].ToCharArray();
                    char[] b = subs.ToCharArray();
                    int position = ArrFindFix[i].IndexOf(subs);
                    if (position==0 && a[b.Length] == ' ')
                        Sequence[i] = 1;
                    else if (position != 0 && a[position-1] == ' ' && a[position+b.Length]== ' ')
                        Sequence[i] = 1;
                    else if (position != 0 && a[position - 1] == ' ' && a[a.Length-1] == b[b.Length-1])
                        Sequence[i] = 1;
                    else
                        Sequence[i] = 0;
                }    
            }
            return Sequence;
        }
    }
}
