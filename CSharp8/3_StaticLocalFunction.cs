using System;

namespace CSharp8
{
    internal class StaticLocalFunction
    {
        public static void Demo()
        {
            static void StaticLocFunc()
            {
                Console.WriteLine("Hi, I am static local function");
            }

            StaticLocFunc();
        }
    }
}
