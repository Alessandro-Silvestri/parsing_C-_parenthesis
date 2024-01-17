/*
C#:
The algorithm reads a text and retrieves only the content inside the parenthesis
Solved by Alessandro Silvestri for Microsoft Learn - 2024 <alessandro.silvestri.work@gmail.com>
*/

using System;

namespace myProgram
{
    class Program
    {
        static void Main(string[] arg)
        {
            int open;
            int close;
            string temp;
            string result = "";
            string message = "(What if) there are (more than) one (set of parentheses)?";

            while ((open = message.IndexOf("(")) != -1 && (close = message.IndexOf(")")) != -1)
            {
                temp = message.Substring(open + 1, (close - open - 1));
                result += temp + ".";
                message = message.Substring(close + 1);
            }

            if (!string.IsNullOrEmpty(result))
            {
                result = result.Substring(0, result.Length - 1);
                string[] resultSplit = result.Split(".");
                foreach (var i in resultSplit)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Nothing to do");
            }
        }
    }
}
