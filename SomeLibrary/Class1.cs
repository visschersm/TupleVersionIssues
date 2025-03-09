using System;
using System.Collections.Generic;

namespace SomeLibrary
{
    public class Class1
    {
        public List<(int, string)> BrokenTupleMethod()
        {
            return new List<(int, string)>
            {
                (1, "one")
            };
        }
    }
}
