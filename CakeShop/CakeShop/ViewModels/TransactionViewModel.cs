using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.ViewModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionViewModel : ControllerBase
    {

        public string Address { get; set; }

        public int Quantity { get; set; }

        public string Buyer { get; set; }
    }
}