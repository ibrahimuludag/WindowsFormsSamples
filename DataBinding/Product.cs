using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }

        public Product(int id, string name , int categoryId, int price)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Price = price;
        }
    }
}
