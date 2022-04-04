using System.Collections.Generic;

namespace Yousif_Models.Models.ViewModels
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
