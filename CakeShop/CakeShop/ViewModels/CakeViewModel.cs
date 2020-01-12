using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.ViewModels
{
    public class CakeViewModel
    {
        public int CakeId { get; set; }
        
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageName { get; set; }

        public string Base64Image { get; set; }

        public string Category { get; set; }
    }
}
