using BuildingBlocks.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingEngine.API.IntegrationEvents.Events
{
    public class OrderCancelledEvent : IntegrationEvent
    {
        public OrderCancelledEvent()
        {

        }
    }
}
