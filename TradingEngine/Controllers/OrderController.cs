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
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> Create()
        {
            return Ok(0);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> Cancel()
        {
            return Ok(0);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> History()
        {
            return Ok(0);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> Open()
        {
            return Ok(0);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("trade/history")]
        public ActionResult<int> TradeHistory()
        {
            return Ok(0);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> Detail()
        {
            return Ok(0);
        }
    }
}