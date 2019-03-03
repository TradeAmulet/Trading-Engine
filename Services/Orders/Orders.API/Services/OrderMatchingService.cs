using Orders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.API.Services
{
    public class OrderMatchingService
    {
        public Orderbook Orderbook { get; set; }

        public void CreateOrder(Order order)
        {
            if (order.Type == OrderType.Limit)
            {
                ProcessLimitOrder(order);
            }
            else
            {
                throw new Exception("Order type " + order.Type.ToString() + " not supported!");
            }
        }

        public void CancelOrder()
        {

        }


        private void ProcessLimitOrder(Order order)
        {
            if(order.Side == OrderSide.Buy)
            {
                ProcessLimitBuyOrder(order);
            }
            ProcessLimitSellOrder(order);
        }

        private List<Trade> ProcessLimitBuyOrder(Order order)
        {
            var trades = new List<Trade>();
            var n = Orderbook.SellOrders.Count();

	        // check if we have at least one matching order
	        if(n != 0 || this.Orderbook.SellOrders[n-1].Price <= order.Price) {

		        // traverse all orders that match
		        for(int i = n - 1; i >= 0; i--){
                    var sellOrder = this.Orderbook.SellOrders[i];
			        if(sellOrder.Price < order.Price){
                        break;
			        }

			        // fill the entire order
			        if(sellOrder.Amount >= order.Amount){
                        trades.Add(new Trade() { TakerOrderId = order.Id, MakerOrderId = sellOrder.Id, Amount = order.Amount, Price = sellOrder.Price });
                        sellOrder.Amount -= order.Amount;
				        if(sellOrder.Amount == 0){
                            this.Orderbook.RemoveSellOrder(i);
				        }
                        return trades;
			        }

			        // fill a partial order and continue
			        if(sellOrder.Amount < order.Amount){
                        trades.Add(new Trade { TakerOrderId = order.Id, MakerOrderId = sellOrder.Id, Amount = sellOrder.Amount, Price = sellOrder.Price });
                        order.Amount -= sellOrder.Amount;

                        this.Orderbook.RemoveSellOrder(i);
                        continue;
			        }
		        }
	        }

	        // Finally, add the remaining order to the list
	        this.Orderbook.AddBuyOrder(order);
	        return trades;
        }

        private List<Trade> ProcessLimitSellOrder(Order order)
        {
            var trades = new List<Trade>();
            var n = this.Orderbook.BuyOrders.Count();

	        // Check if we have at least one matching order
	        if(n != 0 || this.Orderbook.BuyOrders[n-1].Price <= order.Price){

		        // Traverse all orders that match
		        for(var i = n - 1; i >= 0; i--){
                    var buyOrder = this.Orderbook.BuyOrders[i];
			        if(buyOrder.Price > order.Price){
                        break;
			        }

			        // Fill the entire order
			        if(buyOrder.Amount >= order.Amount){
                        trades.Add(new Trade { TakerOrderId = order.Id, MakerOrderId = buyOrder.Id, Amount = order.Amount, Price = buyOrder.Price });
                        buyOrder.Amount -= order.Amount;
				        if(buyOrder.Amount == 0){
                            this.Orderbook.RemoveBuyOrder(i);
				        }
                        return trades;
			        }

			        // Fill a partial order and continue
			        if(buyOrder.Amount < order.Amount){
				        trades.Add(new Trade{ TakerOrderId = order.Id, MakerOrderId = buyOrder.Id, Amount = buyOrder.Amount, Price = buyOrder.Price});
                        order.Amount -= buyOrder.Amount;

                        this.Orderbook.RemoveBuyOrder(i);
                        continue;
			        }
		        }
	        }

            // Finally, add the remaining order to the list
            this.Orderbook.AddSellOrder(order);
	        return trades;
        }
    }
}
