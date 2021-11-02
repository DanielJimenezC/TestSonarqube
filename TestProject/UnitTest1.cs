using NUnit.Framework;
using TestSonarqube.DataAccess;

namespace TestProject
{
    public class Tests
    {
        private DoTest doTest;

        [SetUp]
        public void Setup()
        {
            doTest = new DoTest();
        }

        [Test]
        public void TestGetTestModals()
        {
            var list = doTest.GetTestModals();
            Assert.AreEqual(list.Count, 2);
        }

        [Test]
        public void TestPostTestModals()
        {
            var list = doTest.PostTestModals();
            Assert.AreEqual(list.Count, 3);
        }
    }
}