using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QSS.sqls;
using QSS.Attributes;

namespace itvitea_Restaurant.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        [DatabaseIgnore]
        public List<Consumeables> foodIds { get; set; }  // tussentabel
        [DatabaseIgnore]
        public List<Consumeables> drinkIds { get; set; } // tussentabel
        [DatabaseIgnore]
        public int totalPrice { get; set; }

        public bool completed { get; set; }
    }
}
