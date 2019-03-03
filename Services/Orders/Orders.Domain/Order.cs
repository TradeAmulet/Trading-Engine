using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Domain
{
    public class Order
    {
        public string Id { get; set; }
        public long Amount { get; set; }
        public long Price { get; set; }
        public OrderSide Side { get; set; }
        public OrderType Type { get; set; }
    }
}
