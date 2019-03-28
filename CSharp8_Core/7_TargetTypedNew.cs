using System.Drawing;
using System.Xml;

namespace CSharp8_Core
{
    internal class TargetTypedNew
    {
        // not released in preview yet
        //Point[] ps = { new (1, 4), new (- 2, 5)};

        // umozni i tento zapis definice nove instance
        //var something = new Something();
        //Someting someting = new ();

        public static void Demo()
        {
            //Something.Create(new () { })
        }
    }

    internal class Something
    {
        public static Something Create(Something2 something)
        {
            return new Something();
        }
    }

    internal class Something2
    {
        public int X { get; set; }
    }
}
