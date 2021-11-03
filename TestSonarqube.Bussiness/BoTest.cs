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

        public TestModal GetTestModalsById(string id)
        {
            DoTest doTest = new DoTest();
            TestModal testModal = doTest.GetTestModalsById(id);
            return testModal;
        }

        public List<TestModal> DeleteTestModals()
        {
            DoTest doTest = new DoTest();
            List<TestModal> testModals = doTest.DeleteTestModals();
            return testModals;
        }
    }
}
