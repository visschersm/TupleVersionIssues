﻿using SomeLibrary;

namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        private readonly Class1 _class1 = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _class1.Addition(1, 2);

            Assert.AreEqual(3, result);
        }
    }
}
