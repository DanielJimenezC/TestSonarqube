using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSonarqube.DataAccess;
using TestSonarqube.Domain.Dto;

namespace TestSonarqube.Bussiness
{
    public class BoTest
    {
        public List<TestModal> GetTestModals()
        {
            DoTest doTest = new DoTest();
            List<TestModal> testModals = doTest.GetTestModals();
            return testModals;
        }
    }
}
