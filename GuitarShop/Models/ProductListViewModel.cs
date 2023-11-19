using System.Collections.Generic;

namespace GuitarShop.Models
{
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public string SelectedCategory { get; set; }
        public bool CheckActiveCategory(string category)
        {
            return category == SelectedCategory;
        }
    }
}
