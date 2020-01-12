using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.BindingModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionBindingModel : ControllerBase
    {
        public int CakeId { get; set; }

        public string Address { get; set; }

        public int Quantity { get; set; }

        public string Buyer { get; set; }
    }
}