using System;

namespace CSharp8_Core
{
    internal class NullCoallescingAssignment
    {
        public static void Demo()
        {
            object o = null;
            var something = new object();

            // old way
            if (o == null)
            {
                o = something;
            }

            // c# 8 way
            o ??= something;

            Console.WriteLine(o);
        }
    }
}
