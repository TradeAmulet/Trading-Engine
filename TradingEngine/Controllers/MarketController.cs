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
    public class MarketController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("{instrument}/{currency}/[action]")]
        public ActionResult<int> Tick(string instrument, string currency)
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("{instrument}/{currency}/[action]")]
        public ActionResult<int> Orderbook(string instrument, string currency)
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("{instrument}/{currency}/[action]")]
        public ActionResult<int> Trades(string instrument, string currency, long since)
        {
            return Ok(0);
        }
    }
}