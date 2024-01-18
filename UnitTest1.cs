using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HesloappTest_Munzar_Provaznik
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1POS()
        {
            string heslo = "hfhhRPRmm";
            Assert.IsTrue(heslo.Contains("RPR"));
        }

        [TestMethod]
        public void TestMethod1NEG()
        {
            string heslo = "hfhhmm";
            Assert.IsTrue(heslo.Contains("RPR"));
        }

        [TestMethod]
        public void TestMethod2POS()
        {
            string heslo = "123456789";
            Assert.IsTrue(heslo.Length >= 8 && heslo.Length <= 20); 
        }

        [TestMethod]
        public void TestMethod2NEG()
        {
            string heslo = "1234";
            Assert.IsTrue(heslo.Length >= 8 && heslo.Length <= 20);
        }

        [TestMethod]
        public void TestMethod3POS()
        {
            string heslo = "123";
            Assert.IsTrue(heslo != string.Empty);
        }

        [TestMethod]
        public void TestMethod3NEG()
        {
            string heslo = "";
            Assert.IsTrue(heslo != string.Empty);
        }
    }
}
