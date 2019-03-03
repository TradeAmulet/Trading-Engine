using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TradingEngine.API.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> Balance()
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("{instrument}/{currency}/[action]")]
        public ActionResult<int> TradingFee()
        {
            return Ok(0);
        }
    }
}