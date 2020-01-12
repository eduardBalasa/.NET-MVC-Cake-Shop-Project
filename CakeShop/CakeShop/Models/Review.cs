using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        //public int Rating { get; set; }
               
        public string Comment { get; set; }

        public DateTime Date { get; set; }

        public string Email { get; set; }

        public int CakeId { get; set; }

        public virtual Cake Cake { get; set; }
    }
}
