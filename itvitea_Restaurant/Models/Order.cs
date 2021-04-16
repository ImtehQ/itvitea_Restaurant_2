using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QsScriptExtentions.SQL;
using QsScriptExtentions.Attributes;

namespace itvitea_Restaurant.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public bool Completed { get; set; }



        [DatabaseIgnore]
        public List<Consumeables> foodIds { get; set; }  // tussentabel
        [DatabaseIgnore]
        public List<Consumeables> drinkIds { get; set; } // tussentabel
        [DatabaseIgnore]
        public int totalPrice { get; set; }


    }
}
