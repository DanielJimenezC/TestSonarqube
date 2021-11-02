using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

        [HttpPost]
        public IActionResult PostTestModals()
        {
            BoTest boTest = new BoTest();
            List<TestModal> listado = boTest.PostTestModals();
            return Ok(listado);
        }
    }
}
