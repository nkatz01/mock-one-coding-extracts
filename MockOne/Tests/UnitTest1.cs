using Microsoft.VisualStudio.TestTools.UnitTesting;
using static QuestionOne.Program;
using static Alert.AlertService;
using Alert;
using System;
 
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuestionOne()
        {
            var m1 = ManyTimes("abc", 3);
            Assert.AreEqual("abcabcabc", m1, $"expected abcabcabc not equal to {m1}");
            var m2 =  ManyTimes("123", 2);
            Assert.AreEqual("123123", m2, $"expected 123123 not equal to {m1}");
        }

        [TestMethod]
        public void TestTwoAlertsAreNotEqual()
        {
            AlertDAO strg1 = new AlertDAO();
            AlertDAO strg2 = new AlertDAO();
            strg1.AddAlert(new DateTime());
            strg2.Add(strg1.GetKeyAtPos(0), strg1.GetValAtPos(0).AddMilliseconds(1));
           
         

              Assert.AreEqual(false,strg1.Equals(strg2));
           


        }

     

        [TestMethod]
        public void TestTwoAlertsAreEqual()
        {
            AlertDAO strg1 = new AlertDAO();
            AlertDAO strg2 = new AlertDAO();
            strg1.AddAlert(new DateTime());         
            strg1.AddAlert(new DateTime());

            strg2.Add(strg1.GetKeyAtPos(1), strg1.GetValAtPos(1));
            strg2.Add(strg1.GetKeyAtPos(0), strg1.GetValAtPos(0));
          
            Assert.AreEqual(true, strg1.Equals(strg2));



        }

        [TestMethod]
        public void TestTwoAlertsDiffHash()
        {
            AlertDAO strg1 = new AlertDAO();
            AlertDAO strg2 = new AlertDAO();
            strg1.AddAlert(new DateTime());
            strg2.Add(strg1.GetKeyAtPos(0), strg1.GetValAtPos(0).AddMilliseconds(1));

            Assert.AreEqual(false, strg1.GetHashCode() == strg2.GetHashCode(), $"{ strg1.GetHashCode()} ,{strg2.GetHashCode()}");


           

        }

        [TestMethod]
        public void TestTwoAlertsSameHash()
        {
            AlertDAO strg1 = new AlertDAO();
            AlertDAO strg2 = new AlertDAO();
            strg1.AddAlert(new DateTime());
            strg1.AddAlert(new DateTime());
         

            strg2.Add(strg1.GetKeyAtPos(1), strg1.GetValAtPos(1));
            strg2.Add(strg1.GetKeyAtPos(0), strg1.GetValAtPos(0));

            
             Assert.AreEqual(true, strg1.GetHashCode() == strg2.GetHashCode(), $"{ strg1.GetHashCode()} ,{strg2.GetHashCode()}");
          

        }

        [TestMethod]
        public void TestAlertServiceUsesSameObj()
        {
           AlertService alrtservc  = new AlertService( new AlertDAO());
            var tuple = alrtservc.RaiseAlert();
          
            Assert.AreEqual(true, tuple.Item2 == alrtservc.GetAlertTime(tuple.Item1), $"expected {tuple.Item2 } not equal to {alrtservc.GetAlertTime(tuple.Item1)}");
        }


    }
}

  
 