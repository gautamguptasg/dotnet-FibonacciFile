using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 0, 1 };
            int a = 0, b = 1, c;
            for (int i = 2; i <= 15; i++)
            {
                c = a + b;
                numbers.Add(c);
                a = b;
                b = c;
            }

            using (var writer = new System.IO.StreamWriter("fibonacci"))
            {
                try
                {
                    writer.WriteLine(string.Join(",", numbers));
                    Console.WriteLine("Fibonacci sequence written to file successfully.");
                    Console.WriteLine("Path to file: " + System.IO.Path.GetFullPath("fibonacci"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred writing to the file: " + ex.Message);
                }                
            }
        }
    }
}
