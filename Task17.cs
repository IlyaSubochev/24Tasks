using System;
using System.Collections.Generic;

namespace Level1Space
{

    public static class Level1
    {
        static List<string> Undo = new List<string>();
        static List<string> Redo = new List<string>();
        public static bool UndoFlag = false;
        public static int i = 0;
        public static string Result = "";
        public static string Add(string word)
        {
            if (i>0)
                return Redo[Redo.Count - 1] + word;
            else
            return Undo[Undo.Count - 1] + word;
        }
        public static string Delete(int N, string word)
        {
            string result_word = "";
            if (word.Length > N)
                result_word = word.Remove(word.Length - N);
            else
                result_word = "";
            return result_word;
        }
        public static void CheckUndoRedo(bool flag)
        {
            if (flag == true)
            {
                string Temp = Undo[Undo.Count - 1];
                Undo.Clear();
                Redo.Clear();
                Undo.Add(Temp);
            }
        }
        public static string BastShoe(string command)
        {
            if (Undo.Count == 0)
                Undo.Add(Result);
            string selection = command.Split(' ')[0];
            switch (selection)
            {
                case "1":
                    CheckUndoRedo(UndoFlag);
                    Result = Add(command.Substring(2));
                    Undo.Add(Result);
                    UndoFlag = false;
                    i = 0;
                    break;
                case "2":
                    CheckUndoRedo(UndoFlag);
                    Result = Delete(Convert.ToInt32(command.Split(' ')[1]), Undo[Undo.Count - 1]);
                    Undo.Add(Result);
                    UndoFlag = false;
                    i = 0;
                    break;
                case "3":
                    int Pos = Convert.ToInt32(command.Split(' ')[1]);
                    if (Pos > Undo[Undo.Count - 1].Length-1)
                    {
                        Result = "";
                    }
                    else
                        Result = Undo[Undo.Count - 1].Substring(Pos, 1);
                    break;
                case "4":
                    if (Undo.Count > 1 && i > 0)
                    {
                        Redo.Add(Undo[Undo.Count - 1]);

                        Result = Undo[Undo.Count - 1];
                        UndoFlag = true;
                        i = 0;
                    }
                    else if (Undo.Count > 1)
                    {
                        Redo.Add(Undo[Undo.Count - 1]);
                        Undo.RemoveAt(Undo.Count - 1);
                        Result = Undo[Undo.Count - 1];
                        UndoFlag = true;
                    }
                    else
                        Result = Undo[Undo.Count - 1];                    
                    break;
                case "5":
                    if (Redo.Count > 1)
                    {
                        Undo.Add(Redo[Redo.Count - 1]);
                        Result = Redo[Redo.Count - 1];
                        Redo.RemoveAt(Redo.Count - 1);
                    }
                    else
                    {                        
                        Result = Redo[Redo.Count - 1];
                        i++;
                    }
                    UndoFlag = false;
                    break;
                default:
                    Console.WriteLine("Вы задали некорректную команду");
                    break;
            }
            return Result;
        }
    }
}
