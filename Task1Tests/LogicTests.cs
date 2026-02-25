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
        public void FirstDeclensionOnRubleFirstCondition()
        {
            int enteredValue = 1500;
            string result = Logic.rublesConvert(enteredValue);
            Assert.AreEqual("15 рублей", result);
        }

        [TestMethod()]
        public void FirstDeclensionOnRubleSecondCondition()
        {
            int enteredValue = 3500;
            string result = Logic.rublesConvert(enteredValue);
            Assert.AreEqual("35 рублей", result);
  
        }
        [TestMethod()]
        public void FirstDeclensionOnRubleThirdCondition()
        {
            int enteredValue = 4000;
            string result = Logic.rublesConvert(enteredValue);
            Assert.AreEqual("40 рублей", result);
        }

        [TestMethod()]
        public void SecondDeclensionsOnRubleFirstCondition()
        {
            int enteredValue = 100;
            string result = Logic.rublesConvert(enteredValue);
            Assert.AreEqual("1 рубль", result);

        }
        [TestMethod()]
        public void SecondDeclensionsOnRubleSecondCondition()
        {
            int enteredValue = 5100;
            string result = Logic.rublesConvert(enteredValue);
            Assert.AreEqual("51 рубль", result);
        }


        [TestMethod()]
        public void ThirdDeclensionsOnRuble()
        {
            int enteredValue = 2215;
            string result = Logic.rublesConvert(enteredValue);
            Assert.AreEqual("22 рубля", result);
        }
        [TestMethod()]
        public void FirstDeclensionsOnPenny()
        {
            int enteredValue = 100;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("ровно", result);
        }


        [TestMethod()]
        public void SecondDeclensionsOnPennyFirstCondition()
        {
            int enteredValue = 1115;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("15 копеек", result);
        }

        [TestMethod()]
        public void SecondDeclensionsOnPennySecondCondition()
        {
            int enteredValue = 7;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("7 копеек", result);
        }

        [TestMethod()]
        public void SecondDeclensionsOnPennyThirdCondition()
        {
            int enteredValue = 2020;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("20 копеек", result);
        }

        [TestMethod()]
        public void ThirdDeclensionsOnPennyFirstCondition()
        {
            int enteredValue = 1;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("1 копейка", result);
        }

        [TestMethod()]
        public void ThirdDeclensionsOnPennySecondCondition()
        {
            int enteredValue = 31;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("31 копейка", result);
        }


        [TestMethod()]
        public void FourthDeclensionsOnPenny()
        {
            int enteredValue = 4;
            string result = Logic.pennyConvert(enteredValue);
            Assert.AreEqual("4 копейки", result);
        }

        [TestMethod()]
        public void convertNumberToMoneyStringDefaultTest()
        {
            int enteredValue = 2020;
            string result = Logic.convertNumberToMoneyString(enteredValue);
            Assert.AreEqual("20 рублей 20 копеек", result);
        }
        [TestMethod()]
        public void convertNumberToMoneyStringExactRubTest()
        {
            int enteredValue = 2000;
            string result = Logic.convertNumberToMoneyString(enteredValue);
            Assert.AreEqual("20 рублей ровно", result);
        }
        [TestMethod()]
        public void convertNumberToMoneyStringOnlyPennyTest()
        {
            int enteredValue = 99;
            string result=Logic.convertNumberToMoneyString(enteredValue);
            Assert.AreEqual("99 копеек", result);
        }
        
    }

}