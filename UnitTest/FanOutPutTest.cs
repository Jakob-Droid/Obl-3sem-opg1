using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib.Models;

namespace UnitTest
{
    [TestClass]
    public class FanOutPutTest
    {

        //Arrange
        private FanOutPut _outPut;
        //This is here to get 100% in code coverage ;)
        private FanOutPut _outPut1;

        //Act
        [TestInitialize]
        public void TestInitialize()
        {
            _outPut = new FanOutPut(35, "Jens", 20, 40);
            _outPut1 = new FanOutPut();
        }


        //Assert
        [TestMethod]
        public void TestID()
        {
            Assert.AreEqual(35, _outPut.Id);
            _outPut.Id = 34;
            Assert.AreEqual(34, _outPut.Id);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Jens", _outPut.Navn);
            _outPut.Navn = "12";
            Assert.AreEqual("12", _outPut.Navn);
            try
            {
                _outPut.Navn = null;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Udfyld navn", e.Message);
            }

            try
            {
                _outPut.Navn = "1";
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Navnet skal være længere end 1 karakter", e.Message);
            }
        }

        [TestMethod]
        public void TestTemp()
        {
            Assert.AreEqual(20, _outPut.Temp);
            _outPut.Temp = 25;
            Assert.AreEqual(25, _outPut.Temp);
            try
            {
                _outPut.Temp = 14;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Temp skal være over 15", e.Message);
            }

            try
            {
                _outPut.Temp = 26;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Temp kan ikke være over 25", e.Message);
            }
        }
        [TestMethod]
        public void TestFugt()
        {
            Assert.AreEqual(40, _outPut.Fugt);
            _outPut.Fugt = 50;
            Assert.AreEqual(50, _outPut.Fugt);
            try
            {
                _outPut.Fugt = 29;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Fugt skal være over 30", e.Message);
            }

            try
            {
                _outPut.Fugt = 81;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Fugt skal være over 80", e.Message);
            }
        }
        
    }
}
