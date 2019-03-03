using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TradingEngine.API.Controllers
{
    [Route("v2/market")]
    [ApiController]
    public class MarketV2Controller : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> Active()
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("{instrument}/{currency}/[action]")]
        public ActionResult<int> Trades(string instrument, string currency, int limit, long since, bool indexForward = false)
        {
            return Ok(0);
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("{instrument}/{currency}/[action]/{timeframe}")]
        public ActionResult<int> TicksByTime(string instrument, string currency, string timeframe, int limit, long since, bool indexForward = false, bool sortForward = false)
        {
            return Ok(0);
        }
    }
}