using System.Collections.Generic;

namespace Yousif_Project.Models.ViewModels
{
    public class ProductUserVM
    {
        public ProductUserVM()
        {
            ProductList = new List<Product>();
        }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
