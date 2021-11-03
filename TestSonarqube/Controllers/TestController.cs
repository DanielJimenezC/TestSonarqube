using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using TestSonarqube.Bussiness;
using TestSonarqube.Domain.Dto;

namespace TestSonarqube.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTestValues()
        {
            BoTest boTest = new BoTest();
            List<TestModal> listado = boTest.GetTestModals();
            return Ok(listado);
        }

        [HttpGet("{id}")]
        public IActionResult GetTestModalsById(string id)
        {
            BoTest boTest = new BoTest();
            TestModal listado = boTest.GetTestModalsById(id);
            return Ok(listado);
        }

        [HttpPost]
        public IActionResult PostTestModals()
        {
            BoTest boTest = new BoTest();
            List<TestModal> listado = boTest.PostTestModals();
            return Ok(listado);
        }

        [HttpDelete]
        public IActionResult DeleteTestModals()
        {
            BoTest boTest = new BoTest();
            List<TestModal> listado = boTest.DeleteTestModals();
            return Ok(listado);
        }
    }
}
