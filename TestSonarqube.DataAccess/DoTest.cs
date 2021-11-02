using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSonarqube.Domain.Dto;

namespace TestSonarqube.DataAccess
{
    public class DoTest
    {
        public List<TestModal> testModals;
        TestModal testModal;

        public DoTest()
        {
            testModals = new List<TestModal>();

            //TestModal testModal = new TestModal();
            testModal.Id = "1";
            testModal.Nombre = "Nombre";
            testModal.Telefono = "954754951";
            testModal.Correo = "test@correo2.com";

            TestModal testModal2 = new TestModal();
            testModal2.Id = "2";
            testModal2.Nombre = "Apellido";
            testModal2.Telefono = "995487002";
            testModal2.Correo = "pruebas@correo2.com";

            testModals.Add(testModal);
            testModals.Add(testModal2);
        }

        public List<TestModal> GetTestModals()
        {
            return testModals;
        }
    }
}
