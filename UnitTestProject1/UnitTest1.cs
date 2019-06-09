using System;
using System.IO.Pipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRouletteProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Trig myTrig = new Trig();

        [TestMethod]
        public void RNDTest()
        {
            int Actual = myTrig.RNDNumberGenerate();
            Assert.IsTrue(Actual > 1 && Actual < 7);
        }

        [TestMethod]
        public void ShotCounter()
        {
            int Expected = 1;
            int Actual = myTrig.ShotsFired();
            Assert.AreEqual(Expected, Actual);
        }
    }
}
