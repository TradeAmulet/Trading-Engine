using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Orders.API.Controllers
{
    [Route("v2/order")]
    [ApiController]
    public class OrderV2Controller : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("open/{instrument}/{currency}")]
        public ActionResult<int> Open(string instrument, string currency)
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("history/{instrument}/{currency}")]
        public ActionResult<int> History(string instrument, string currency)
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("trade/history/{instrument}/{currency}")]
        public ActionResult<int> TradeHistory(string instrument, string currency, bool indexForward, int limit, long since)
        {
            return Ok(0);
        }
    }
}