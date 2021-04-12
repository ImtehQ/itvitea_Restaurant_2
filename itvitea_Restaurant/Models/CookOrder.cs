using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itvitea_Restaurant.Models
{
    public class CookOrder
    {
        public int Id { get; set; }
        public int tableId { get; set; }
        public int foodId { get; set; }
    }
}
