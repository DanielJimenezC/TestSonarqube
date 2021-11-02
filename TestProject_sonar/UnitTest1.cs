using System;
using TestSonarqube.DataAccess;
using TestSonarqube.Domain.Dto;
using Xunit;

namespace TestProject_sonar
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetTestModals()
        {
            DoTest doTest = new DoTest();
            var list = doTest.GetTestModals();
            Assert.Equal(list.Count, 2);
        }

        [Fact]
        public void TestPostTestModals()
        {
            DoTest doTest = new DoTest();
            var list = doTest.PostTestModals();
            Assert.Equal(list.Count, 3);
        }
    }
}
