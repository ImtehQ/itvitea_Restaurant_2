using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itvitea_Restaurant.Models
{
    public class ConsumeableOrders
    {
        public int consumeableId { get; set; }
        public int orderId { get; set; }
        public string remarks { get; set; }
        public double price { get; set; }
        public bool ready { get; set; }
    }
}
