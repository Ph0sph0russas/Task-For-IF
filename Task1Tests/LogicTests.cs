using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FirstDeclensionsOnRubleAndPennyTest()
        {
            int enteredValue = 1501;
            string result = Logic.Transformation(enteredValue);
            Assert.AreEqual("15 рублей 1 копейка", result);

        }
        [TestMethod()]
        public void SecondDeclensionsOnRubleAndPennyTest()
        {
            int enteredValue = 100;
            string result = Logic.Transformation(enteredValue);
            Assert.AreEqual("1 рубль ровно", result);
        }
        [TestMethod()]
        public void ThirdDeclensionsOnRubleAndPennyTest()
        {
            int enteredValue = 2215;
            string result = Logic.Transformation(enteredValue);
            Assert.AreEqual("22 рубля 15 копеек", result);
        }
        [TestMethod()]
        public void FourthDeclensionsOnPennyWithoutRublesTest()
        {
            int enteredValue = 4;
            string result = Logic.Transformation(enteredValue);
            Assert.AreEqual("4 копейки", result);
        }
    }
}