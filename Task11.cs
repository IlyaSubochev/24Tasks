using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static double MyRound(double x, int precision)
        {
            return ((int)(x * Math.Pow(10.0, precision)) / Math.Pow(10.0, precision));
        }
        public static string MassVote(int N, int[] Votes)
        {
            string res = "";
            double ValueVotes = 0;
            double max;
            int k = 1;
            double[] PerVotes = new double[N];
            for (int i = 0; i < N; i++)
                ValueVotes = ValueVotes + Votes[i];
            for (int i = 0; i < N; i++)
                PerVotes[i] = MyRound((Votes[i] * 100) / ValueVotes,2);
            max = PerVotes[0];
            int maxFlag = 0;
            for (int i = 0; i < N; i++)
            {
                if (max < PerVotes[i])
                {
                    k = i + 1;
                    max = PerVotes[i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (max == PerVotes[i])               
                    maxFlag++;                
            }
            if (max > 50 && maxFlag==1)
                res = "majority winner " + k;
            else if ((max > 50 && maxFlag > 1) || (max < 50 && max > 40 && maxFlag > 1))
                res = "no winner";
            else if (max < 50 && max > 40 && maxFlag == 1)
                res = "minority winner " + k;
            else
                res = "no winner";
            return res;
        }
    }
}
