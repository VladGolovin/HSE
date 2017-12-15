namespace TestExample
{
    using Cow;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
	public class UnitTest1
	{
        [TestMethod]
        public void TestMethod1()
        {
            Cow cow = new Cow();
            Assert.AreEqual("коров", cow.CowCounter(28));
            Assert.AreEqual("корова", cow.CowCounter(101));
            Assert.AreEqual("коровы", cow.CowCounter(1224));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Cow cow = new Cow();
            Assert.AreEqual("коров", cow.CowCounter(1111));
        }
    }
}
