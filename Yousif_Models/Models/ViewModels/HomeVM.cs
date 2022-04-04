using System.Collections.Generic;

namespace Yousif_Models.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
