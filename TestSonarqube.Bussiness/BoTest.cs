using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSonarqube.DataAccess;
using TestSonarqube.Domain.Dto;

namespace TestSonarqube.Bussiness
{
    [ExcludeFromCodeCoverage]
    public class BoTest
    {
        public List<TestModal> GetTestModals()
        {
            DoTest doTest = new DoTest();
            List<TestModal> testModals = doTest.GetTestModals();
            return testModals;
        }

        public List<TestModal> PostTestModals()
        {
            DoTest doTest = new DoTest();
            List<TestModal> testModals = doTest.PostTestModals();
            return testModals;
        }
    }
}
