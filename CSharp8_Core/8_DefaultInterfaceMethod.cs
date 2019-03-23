using System;

namespace CSharp8_Core
{
    internal class DefaultInterfaceMethod
    {

    }

    internal interface TestInterface
    {
        void Do(int i);

        // default implementation of method
        //void DoDefault() => this.Do(0); 
    }

    internal class SomethingImplemneting : TestInterface
    {
        public void Do(int i)
        {
            Console.WriteLine(i);
        }
    }
}
