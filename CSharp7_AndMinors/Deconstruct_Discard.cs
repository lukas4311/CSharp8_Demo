using System;
using System.Drawing;

namespace CSharp7_AndMinors
{
    internal class Deconstruct_Discard
    {
        public static void Demo()
        {
            var a = Tuple.Create(10, 20, "aaaa", new Point(10,10));
            var b = (10, 20, "aaa");

            // object deconstruct
            var (X, Y) = new Test { X = 10, Y = 20 };
        }

        public static void DemoDiscard()
        {
            // Example of usage discard (_) in tuple deconstruct
            (int X, int _) = new Point(1, 5);

            // Example of usage discard in out param
            bool isNumer = int.TryParse("10", out int _);

            // Discards with pattern matching
            object x = 10;

            if(x is int _)
            {
                // do something 
            }
        }
    }

    // Example of extension if deconstruct to existin .net object
    public static class PointExtesion
    {
        public static void Deconstruct(this Point point, out int x, out int y)
        {
            x = point.X;
            y = point.Y;
        }
    }

    internal class Test
    {
        public int X { get; set; }

        public int Y { get; set; }

        public void Deconstruct(out int x, out int y)
        {
            x = this.X;
            y = this.Y;
        }
    }
}
