using System;
using System.Linq;

namespace LambdaExp
{
    class Program
    {
        static void Main(string[] args)
        {   // Lambda expresssons anonymous Functions, inline functions, they replace the normal methods to write
            int[] array = Console.ReadLine()  // no name functions, give built in functionality
                .Split(" ", StringSplitOptions  // provide better readable code
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] evenNumbers = array
                .Where((x, index) =>
               {
                   Console.WriteLine($"Checking at Array[{index}] {x} % 2 == 0 -> {x % 2 == 0}");
                   return x % 2 == 0;  // Predicate- function that returns yes or no
                })
                .ToArray();

            Console.WriteLine(string.Join(" ", evenNumbers));
            
        }
    }
}
