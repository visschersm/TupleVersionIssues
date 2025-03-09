using System;

namespace SomeLibrary
{
    public class Class1
    {
        public (int, string) BrokenTupleMethod()
        {
            return (1, "one");
        }
    }
}
