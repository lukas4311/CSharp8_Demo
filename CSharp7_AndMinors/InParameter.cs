using System;

namespace CSharp7_AndMinors
{
    internal class InParameter
    {
        public static void Demo()
        {
            int readonlyArgument = 44;
            InArgExample(readonlyArgument);
            Console.WriteLine(readonlyArgument);

            void InArgExample(in int number)
            {
                // Next row will raise compilation error after uncomment
                //number = 19;
            }
        }
    }
}
