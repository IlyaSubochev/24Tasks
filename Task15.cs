using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool LineAnalysis(string line)
        {
            bool CorrectString = false;
            int Temp = 0;
            string TempStr = "";
            int CorrVal = 0;
            char[] CorrLine = line.ToCharArray();
            for (int i = 0; i < CorrLine.Length; i++)
            {
                if (CorrLine[i] == '*')
                    CorrVal++;
            }
            if (CorrVal==1 && line.Length==1)
                CorrectString = true;
            else if (CorrVal > 1)
            {
                string[] ArrLine = line.Split('*');
                TempStr = ArrLine[1];
                for (int i = 1; i < ArrLine.Length-1; i++)
                {
                    if (TempStr == ArrLine[i])
                        Temp++;
                }
                if (Temp == ArrLine.Length - 2)
                    CorrectString = true;
            }           
            return CorrectString;           
        }
    }
}
