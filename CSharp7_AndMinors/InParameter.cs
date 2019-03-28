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
                // number = 19;
            }

            BigObject bigObject = new BigObject();
            bigObject.BigInt = 9999999999.9999M;
            bigObject.BigInt2 = 9999999999.9999M;
            bigObject.BigInt3 = 9999999999.9999M;
            bigObject.BigInt4 = 9999999999.9999M;
        }

        struct BigObject
        {
            public decimal BigInt;
            public decimal BigInt2;
            public decimal BigInt3;
            public decimal BigInt4;
        }
    }
}
