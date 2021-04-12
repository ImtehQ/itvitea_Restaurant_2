using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itvitea_Restaurant.Models
{
    public class Consumeables
    {
        public int id { get; set; }
        public int type { get; set; }
        public string name { get; set; }
        public string discription { get; set; }
        public bool isReady { get; set; }
    }
}
