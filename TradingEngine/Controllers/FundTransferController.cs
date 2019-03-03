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
    public class FundTransferController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> WithdrawCrypto(long amount, string address, string currency)
        {
            return Ok(0);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> WithdrawEFT(string accountName, int accountNumber, string bankName, int bsbNumber, long amount, string currency = "AUD")
        {
            return Ok(0);
        }

        [HttpGet]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [Route("[action]")]
        public ActionResult<int> History(int limit, long since, bool indexForward = false)
        {
            return Ok(0);
        }
    }
}