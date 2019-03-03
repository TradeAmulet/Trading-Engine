using System.Collections.Generic;

namespace Orders.Domain
{
    public class Orderbook
    {
        public List<Order> BuyOrders { get; private set; }
        public List<Order> SellOrders { get; private set; }

        public Orderbook()
        {
            BuyOrders = new List<Order>(4096);
            SellOrders = new List<Order>(4096);
        }

        public void AddBuyOrder(Order order)
        {
            var orderbookLength = BuyOrders.Count;
            int i = orderbookLength - 1;

            for (; i >= 0; i--)
            {
                if (this.BuyOrders[i].Price < order.Price)
                {
                    break;
                }
            }

            if (i == orderbookLength - 1)
            {
                this.BuyOrders.Add(order);
            }
            else
            {
                this.BuyOrders.Insert(i, order);
            }
        }

        public void AddSellOrder(Order order)
        {
            var orderbookLength = SellOrders.Count;
            int i = orderbookLength - 1;

            for (; i >= 0; i--)
            {
                if (this.SellOrders[i].Price > order.Price)
                {
                    break;
                }
            }

            if (i == orderbookLength - 1)
            {
                this.SellOrders.Add(order);
            }
            else
            {
                this.SellOrders.Insert(i, order);
            }
        }

        public void RemoveBuyOrder(int index)
        {
            this.BuyOrders.RemoveAt(index);
        }

        public void RemoveSellOrder(int index)
        {
            this.SellOrders.RemoveAt(index);
        }
    }
}
