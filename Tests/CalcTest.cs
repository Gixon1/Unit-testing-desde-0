using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingMsTestIntro;

namespace Tests
{
    [DataRow(4, 4, 8)]
    [DataRow(24, 26, 50)]
    [TestClass]
      public class CalcTest
    {
        [TestMethod]

        public void Sum_ShoulCalcAndReturnSameValue(int a, int b, int expected)
        {
            //Arrage
            
            //Act
            int actual = Calcs.Sum(a, b);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
