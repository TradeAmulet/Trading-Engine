using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Domain
{
    public class Trade
    {
        public string TakerOrderId { get; set; }
        public string MakerOrderId { get; set; }
        public long Amount { get; set; }
        public long Price { get; set; }
    }
}
