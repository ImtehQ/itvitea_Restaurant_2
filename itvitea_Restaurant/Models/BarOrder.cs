using QSS.Attributes;

namespace itvitea_Restaurant.Models
{
    public class BarOrder
    {
        public int id { get; set; }
        public int tableId { get; set; }
        public int drinkId { get; set; }
    }
}