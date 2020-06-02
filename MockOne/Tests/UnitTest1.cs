using Microsoft.VisualStudio.TestTools.UnitTesting;
using static QuestionOne.Program;
using static Alert.AlertService;
using Alert;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

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
           
            //Dictionary<int, string> dict1 = new Dictionary<int, string>{ { 1, "baba" },
            //    {2, "bibi" } };
         
            //Dictionary<int, string> dict2 = new Dictionary<int, string> {
            //      {2, "bibi" }, { 1, "baba" } };

              Assert.AreEqual(false,strg1.Equals(strg2));
           // Assert.AreEqual(true, Enumerable.SequenceEqual(dict1, dict2));
            //   Assert.AreEqual(true, Enumerable.SequenceEqual(dict1.OrderBy(e => e.Key), dict2.OrderBy(e => e.Key)));


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


            // Assert.AreEqual(true, Enumerable.SequenceEqual(dict1, dict2));
            //   Assert.AreEqual(true, Enumerable.SequenceEqual(dict1.OrderBy(e => e.Key), dict2.OrderBy(e => e.Key)));


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

            //Dictionary<int, string> dict1 = new Dictionary<int, string>{ { 1, "baba" },
            //    {2, "bibi" } };

            //Dictionary<int, string> dict2 = new Dictionary<int, string> {
            //      {2, "bibi" }, { 1, "baba" } };

            //Dictionary<int, string> dict1 = new Dictionary<int, string>{ { 1, "baba" },  };

            //Dictionary<int, string> dict2 = new Dictionary<int, string> {
            //      { 1, "baba" } };
             Assert.AreEqual(true, strg1.GetHashCode() == strg2.GetHashCode(), $"{ strg1.GetHashCode()} ,{strg2.GetHashCode()}");
          //  Assert.AreEqual(true, dict1.First().GetHashCode() == dict2.First().GetHashCode(), $"{ dict1.GetHashCode()} ,{dict2.GetHashCode()}");
            //   Assert.AreEqual(true, Enumerable.SequenceEqual(dict1.OrderBy(e => e.Key), dict2.OrderBy(e => e.Key)));


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

  
 