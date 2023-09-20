using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            string str = "";

            foreach (var c in arr)
            {
                try
                {
                    int num = int.Parse(c.ToString());
                    numbers.Add(num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + $": {c}");
                }

            }
            foreach (var c1 in numbers)
            {
                Console.WriteLine(c1);
            }

        }
    }
}
