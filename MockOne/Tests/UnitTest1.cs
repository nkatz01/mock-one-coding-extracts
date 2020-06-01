using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var m1 = QuestionOne.Program.ManyTimes("abc", 3);
            Assert.AreEqual("abcabcabc", m1, $"abcabcabc not equal to {m1}");
            var m2 = QuestionOne.Program.ManyTimes("123", 2);
            Assert.AreEqual("123123", m2, $"123123 not equal to {m1}");
        }
    }
}

  
 