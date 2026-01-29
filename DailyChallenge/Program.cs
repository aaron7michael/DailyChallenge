using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DailyChallenge
{
    public class Program
    {
        public static void Main()
        {
            int[] q = Jan302026.Interleave([2, 4, 3, 1, 6, 5]);
            string results="[";
            for(int i = 0; i<(q.Length - 1); i++)
            {
                results += $"{q[i].ToString()},";
            }
            results += $"{q[q.Length - 1].ToString()}]";
            Console.WriteLine(results);
        }
    }
}
