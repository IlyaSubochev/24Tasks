using System;
using System.Collections.Generic;


namespace Level1Space
{

    public static class Level1
    {
        public static List<string> words = new List<string>();
        private static void MagicWord(string input,int a, int b)
        {
            if (a == b)
                words.Add(input); 
            else
            {
                for (int i = a; i <= b; i++)
                {
                    input = ReductionMagicWord(input, a, i);
                    MagicWord(input, a + 1, b);
                    input = ReductionMagicWord(input, a, i);
                }
            }
        }
        public static string ReductionMagicWord(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        public static string BiggerGreater(string input)
        {
            string Result = input;
            
            int n = Result.Length;
            MagicWord(Result, 0, n - 1);
            words.Sort();
            int t = words.Count;
            foreach (var item in words)
            {
                if (words[0] == item)               
                    t--;               
            }
            if (t==0)
                Result = "";
            else if ((words.IndexOf(input) + 1)>(words.Count-1))
                Result = "";
            else
                Result = words[words.IndexOf(input) + 1];
            words.Clear();
            return Result;
        }
    }
}
