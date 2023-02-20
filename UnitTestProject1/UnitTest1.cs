using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckVIN()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.CheckVIN("JHMCM56557C404453"));
        }

        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Azia", class1.GetVINCountry("1FVACWDU1BHBB3474"));
        }

        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Afrika", class1.GetVINCountry("JH4KA3160JC002842"));
        }

        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Evropa", class1.GetVINCountry("SHSRD78875U336227"));
        }


        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("North America", class1.GetVINCountry("KM8SC73E94U774838"));
        }

        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Okeainia", class1.GetVINCountry("JH4DB1542MS007683"));
        }

        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("South America", class1.GetVINCountry("1FVNY5Y90HP312888"));
        }    
    }
}
