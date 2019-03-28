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
            Index index = 5;
            Index reverseIndex = ^1;

            WriteLine(numbers[2]); // result 2
            WriteLine(numbers[reverseIndex]); //result 9

            WriteLine();

            
            var a = 2;
            int b = 8;
            var slice = numbers[a..reverseIndex];
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

            //foreach (var item in 10..15)
            //{
            //}
        }
    }
}
