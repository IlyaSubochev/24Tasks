using System;
using System.Collections.Generic;


namespace Level1Space
{

    public static class Level1
    {
        public static Boolean SherlockValidString(string s)
        {
            bool Result = false;
            List<int> Valid = new List<int>();
            string Temp = s.Substring(0, 1);
            int count = 0;
            while (s.Length != 0)
            {
                if (s.IndexOf(Temp) != -1)
                {
                    count++;
                    s = s.Remove(s.IndexOf(Temp), 1);
                    if (s.Length == 0)
                        Valid.Add(count);
                }
                else
                {
                    Valid.Add(count);
                    Temp = s.Substring(0, 1);
                    count = 0;
                }
            }
            int SumCountMax = Valid[0];
            int SumCountMin = Valid[0];
            int MinPos = 0;
            foreach (var item in Valid)
            {
                if (SumCountMax < item)
                    SumCountMax = item;
                else if (SumCountMin > item)
                {
                    SumCountMin = item;
                    MinPos = Valid.IndexOf(item);
                }
            }
            int AllEqual = 0;
            int OneCut = 0;
            foreach (var item in Valid)
            {
                if (SumCountMax == item)
                    AllEqual++;
                else if ((SumCountMax - 1) == item)
                    OneCut++;
            }
            if (AllEqual == Valid.Count  || (OneCut == (Valid.Count - 1) && AllEqual == 1)
                || (AllEqual == (Valid.Count - 1) && OneCut == 1 && Valid[MinPos] == 1))
                Result = true;
            Valid.Clear();
            return Result;
        }
    }
}
