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
            string[] ArrFind;
            if (ArrStringEqualize.Length == 1)
            {               
                char[] TempArr = ArrStringEqualize[0].ToCharArray();
                ArrFind = new string[TempArr.Length / len + 1];
                for (int i = 0; i < ArrFind.Length; i++)
                {
                    int jj = 0;
                    for (int j = i*len; j < TempArr.Length; j++)
                    {                        
                        if (j < ((i + 1) * len) && jj < len)
                        {
                            ArrFind[i] = ArrFind[i] + TempArr[j];
                            jj++;
                        }                       
                    }
                }
            }
            else
            {
                ArrFind = new string[ArrStringEqualize.Length + 1];
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
                    if (i < Sequence.Length - 1 && position ==0 && a.Length == b.Length)
                        Sequence[i] = 1;
                    else if (i < Sequence.Length - 1 && position == 0 && a.Length > b.Length && a[b.Length] == ' ')
                        Sequence[i] = 1;
                    else if (a.Length > b.Length && position == 0 && a[b.Length-1] == b[b.Length-1] && i == Sequence.Length-1)
                        Sequence[i] = 1;
                    else if (a.Length > b.Length && position != 0 && a[position-1] == ' ' && a[position+b.Length-1]== ' ')
                        Sequence[i] = 1;
                    else if (a.Length > b.Length && position != 0 && a[position - 1] == ' ' && (a[a.Length-1] == b[b.Length-1]
                        || a[a.Length-1]=='.'))
                        Sequence[i] = 1;
                    else
                        Sequence[i] = 0;
                }    
            }
            return Sequence;
        }
    }
}
