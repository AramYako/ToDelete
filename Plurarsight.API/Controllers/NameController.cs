using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurarsight.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly List<string> Names = new List<string>
        {
            "Aram", "AramOne", "AramTwo"
        };

  

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(Names);
        }

        [HttpPost]
        public ActionResult<IEnumerable<string>> CreateName(string name)
        {
            Names.Add(name);

            return Ok(name);
        }
    }
}
