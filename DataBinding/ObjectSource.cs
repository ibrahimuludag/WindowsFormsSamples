using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class ObjectSource
    {
        private List<Category> _categories;
        private List<Product> _products;

        public ObjectSource()
        {
            _categories = new List<Category>()
            {
                new Category(1 , "Notebook"),
                new Category(2 , "PC"),
                new Category(3 , "Phone")
            };

            _products = new List<Product>()
            {
                new Product(1 , "Toshiba" , 1 , 10),
                new Product(2 , "Dell" , 1,20),
                new Product(3 , "HP" , 1,30),
                new Product(4 , "Monster" , 2,40),
                new Product(5 , "IPhone" , 3,50),
                new Product(6 , "Samsung Galaxy" , 3,60 ),
            };
        }

        public List<Category> GetCategories()
        {
            return _categories;
        }

        public List<Product> GetProducts(int categoryId)
        {
            return _products.Where(c => c.CategoryId == categoryId).ToList();
        }
    }
}
