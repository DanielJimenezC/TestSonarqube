using System;
using TestSonarqube.DataAccess;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        private DoTest doTest;

        [Fact]
        public void GetTestModals()
        {
            doTest = new DoTest();
            var list = doTest.GetTestModals();
            Assert.Equal(list.Count, 2);
        }

        [Fact]
        public void PostTestModals()
        {
            doTest = new DoTest();
            var list = doTest.PostTestModals();
            Assert.Equal(list.Count, 3);
        }
    }
}
