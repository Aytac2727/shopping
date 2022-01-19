using Entities;
using System.Collections.Generic;

namespace UI.ViewModels
{
    public class DetailProductVM
    {
        public Product Product { get; set; }
        public List<Product> SameProduct { get; set; }
    }
}
