using System;
using System.Collections.Generic;


namespace Level1Space
{
    public static class Level1
    {
        public static string result = "";
        static string RecParentheses(char[] Str, int Position, int N, int OpenParentheses, int CloseParentheses)
        {
            if (CloseParentheses == N)
            {
                for (int i = 0; i < Str.Length; i++)
                    result = result + Str[i];
                result = result + " ";
                return result;
            }
            else
            {
                if (OpenParentheses > CloseParentheses)
                {
                    Str[Position] = ')';
                    RecParentheses(Str, Position + 1, N, OpenParentheses, CloseParentheses + 1);
                }
                if (OpenParentheses < N)
                {
                    Str[Position] = '('; RecParentheses(Str, Position + 1, N, OpenParentheses + 1, CloseParentheses);
                }
            }
            return result;
        }
        public static string BalancedParentheses(int N)
        {
            string Result = "";
            char[] Str = new char[2 * N];
            Result = RecParentheses(Str, 0, N, 0, 0);
            Result = Result.Remove(Result.Length-1);
            result = "";
            return Result;
        }
    }
}
