using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plurarsight.API.Controllers
{
    namespace Plurarsight.API.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class FunctionController : ControllerBase
        {
            private static readonly List<string> Functions = new List<string>
        {
            "Get", "Post"
            };



            [HttpGet]
            public ActionResult<IEnumerable<string>> Get()
            {
                return Ok(Functions);
            }

            [HttpPost]
            public ActionResult<IEnumerable<string>> Create(string function)
            {
                Functions.Add(function);

                return Ok(function);
            }
        }
    }
}
