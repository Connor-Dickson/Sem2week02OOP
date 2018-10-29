using System;

namespace NewAPI.Controllers
{
    public class ShoppingItems
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Guid ID { get; set; }


        public ShoppingItems(string name, int price, Guid id)
        {
            this.Name = name;
            this.Price = price;
            this.ID = id;
        }
    }
}
