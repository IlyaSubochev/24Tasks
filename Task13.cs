using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int Unmanned(int L, int N, int[][] track)
        {
            int result = 0;
            int DistL = 0;
            int i = 0;
            for (int j = 1; j < N; j++)
            {
                int[] TempTrack = new int[3];

                if (track[0][0] > track[j][0])
                {
                    TempTrack = track[j];
                    track[j] = track[0];
                    track[0] = TempTrack;
                }
            }
            while (DistL <= L)
            {
                if (i == N)
                {
                    result = result + L - DistL;
                    DistL = L + 1;
                }
                else
                {
                    if (DistL == L && track[track.Length-1][0] != L)                   
                        DistL = DistL+1;
                    else if (i < N && DistL == track[i][0])
                    {
                        if (N > 1 && DistL == track[i][0] && result == (track[0][1] + track[1][1]))
                        {
                            DistL++;
                            result++;
                        }
                        else if (DistL < track[i][1])
                        {
                            result = result + track[i][1] - DistL;
                            //DistL++;
                        }
                        else if (DistL > track[i][1] && result > track[i][1] && result % (track[i][1] * 2) < 5)
                        {
                            result = result + (track[i][1] - (result - track[i][1] * (result / track[i][1])));
                            //DistL++;
                        }
                        else if (DistL > track[i][1] && result < track[i][1] && result % (track[i][1] * 2) < 5)
                        {
                            result = result + (track[i][1] - result);
                            //DistL++;
                        }
                        i++;
                    }
                    else
                    {
                        DistL++;
                        result++;
                    }
                }

            }
            return result;
        }
    }
}
