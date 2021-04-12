using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itvitea_Restaurant.Models
{
    public class Orders
    {
        public int id { get; set; }
        public int tableId { get; set; }
        public List<Consumeables> foodIds { get; set; }  // tussentabel
        public List<Consumeables> drinkIds { get; set; } // tussentabel
        public int totalPrice { get; set; }
        public bool completed { get; set; }
    }
}
