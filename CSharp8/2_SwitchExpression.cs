using System;
using static System.Console;

namespace CSharp8
{
    internal class SwitchExpression
    {
        public static void Demo()
        {
            // Old way
            WriteLine("\nOld way");
            string DoOld(object o)
            {
                switch (o)
                {
                    case Test t when t.A == 1:
                        var a = 0;
                        return "A = 1";
                    case Test t:
                        return "A != 1";
                    default:
                        return "Bad data type";
                }
            }
            WriteLine(DoOld(new Test { A = 1, B = 0 }));

            // pattern matching
            WriteLine("\nPattern matching");
            string Do(object o) => o switch
            {
                Test t when t.A == 1 => "A = 1",
                Test t => "A != 1",
                _ => "Bad data type"
            };
            WriteLine(Do(new Test { A = 1, B = 0 }));

            WriteLine("\nProperty matching");
            string DoProp(object o) => o switch
            {
                Test { A: 2, B: int b } => b.ToString(),
                Test { B: var b, A: var a } => $"A:{a}, B:{b}",
                _ => "Bad data type"
            };
            WriteLine(DoProp(new Test { A = 3, B = 2 }));

            WriteLine("\nProperty matching 2");
            string DoProp2(object o) => o switch
            {
                Test { A: 2, B: var b } => $"A = 1 AND B is: {b}",
                Test { B: var b, A: var a } => $"A:{a}, B:{b}",
                { } => o.ToString(), //{} => not null
                null => "Null"
            };
            WriteLine(DoProp2("Wiiiiiiiii"));

            WriteLine("\nTuple deconstrunct matching");
            (var a, var b) = new Test { A = 10, B = 20 };
            string DoTuple(object o) => o switch
            {
                Test(10, 20) => $"Bingo",
                Test(var a, var b) => $"{a} {b}",
                _ => "Bat data type"
            };
            WriteLine(DoTuple(new Test { A = 10, B = 20 }));

            WriteLine("\nTuple conditions");
            string ResolveState(bool? conditionA, bool? conditionB, bool superCondition) => (conditionA, conditionB) switch
            {
                (true, true) => "Yes",
                (false, true) when superCondition => "Yes",
                (false, true) => "No",
                (true, false) => "No",
                (false, false) => "No",
                _ => throw new InvalidOperationException("Bad operation")
            };
            WriteLine(ResolveState(false, true, true));
            WriteLine(ResolveState(false, true, false));

            // Alternative tuple pattern matching
            string ResolveStateAlternative(bool? conditionA, bool? conditionB, bool superCondition) => (conditionA, conditionB, superCondition) switch
            {
                (true, true, _) => "Yes",
                (false, true, true) => "Yes",
                (false, true, _) => "No",
                (true, false, _) => "No",
                (false, false, _) => "No",
                _ => throw new InvalidOperationException("Bad operation")
            };
            WriteLine(ResolveStateAlternative(false, true, true));
            WriteLine(ResolveStateAlternative(false, true, false));
        }

        internal class Test
        {
            public int A { get; set; }

            public int B { get; set; }

            public void Deconstruct(out int a, out int b)
            {
                a = this.A;
                b = this.B;
            }
        }
    }
}
