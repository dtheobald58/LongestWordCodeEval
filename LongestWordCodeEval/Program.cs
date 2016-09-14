using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordCodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "awesome lobster on fire";

            string[]splitLine = line.Split(' ');
            string longWord = "";

            for (int i = 0; (i <= splitLine.Length-1); i++)
            {
                if (splitLine[i].Length > longWord.Length)
                {
                    longWord = splitLine[i];
                }
            }
            Console.WriteLine(longWord);
        }
    }
}
