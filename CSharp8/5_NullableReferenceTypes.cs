using static System.Console;

namespace CSharp8
{
    internal class NullableReferenceTypes
    {
        public static void Demo()
        {
#nullable enable
            string s = null;
            WriteLine(s);

            string? nullableString = null;
            WriteLine(nullableString.Length);

            string? nullStr = null;
            WriteLine(nullStr!.Length); //! dammit operator (no runtime effect)
#nullable disable
        }
    }
}
