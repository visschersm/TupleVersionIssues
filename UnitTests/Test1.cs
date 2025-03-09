using SomeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        private readonly Class1 _class1 = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _class1.BrokenTupleMethod();

            Assert.IsNotEmpty(result);
        }
    }
}
