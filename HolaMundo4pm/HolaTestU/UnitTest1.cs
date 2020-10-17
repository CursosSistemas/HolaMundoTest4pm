using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HolaMundo4pm;

namespace HolaTestU
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hola Mundo1", Program.createMessage());
        }
    }
}
