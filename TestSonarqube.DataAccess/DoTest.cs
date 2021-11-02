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
        private List<TestModal> testModals;

        public DoTest()
        {
            testModals = new List<TestModal>();

            TestModal testModal = new TestModal();
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

        public List<TestModal> PostTestModals()
        {
            TestModal testModal = new TestModal();
            testModal.Id = "3";
            testModal.Nombre = "Direccion";
            testModal.Telefono = "9845222590";
            testModal.Correo = "pruebas@correo.com";

            testModals.Add(testModal);

            return testModals;
        }
    }
}
