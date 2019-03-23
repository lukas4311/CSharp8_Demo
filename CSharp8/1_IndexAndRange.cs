using System;
using System.Linq;
using static System.Console;

namespace CSharp8
{
    internal class IndexAndRange
    {
        public static void Demo()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Index index = 2;
            Index reverseIndex = ^1;

            WriteLine(numbers[index]); // result 2
            WriteLine(numbers[reverseIndex]); //result 9

            WriteLine();
            var slice = numbers[2..5];
            slice.ToList().ForEach(a => Write(a));
            WriteLine();

            WriteLine();
            slice = numbers[2..^1];
            slice.ToList().ForEach(a => Write(a));
            WriteLine();

            WriteLine();
            slice = numbers[6..];
            slice.ToList().ForEach(a => Write(a));
            WriteLine();

            WriteLine();
            slice = numbers[..];
            slice.ToList().ForEach(a => Write(a));
            WriteLine();
        }
    }
}
