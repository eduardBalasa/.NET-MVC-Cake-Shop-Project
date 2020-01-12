using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CakeShop.BindingModels;
using CakeShop.Models;
using CakeShop.Repositories.Interfaces;
using CakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CakeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public TransactionController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        // POST: api/Transaction
        [HttpPost]
        public async Task<ActionResult> PostTransaction(TransactionBindingModel transactionBidingModel)
        {
            var transaction = _mapper.Map<Transaction>(transactionBidingModel);
            _repositoryWrapper.TransactionRepository.Create(transaction);
            _repositoryWrapper.Save();

            return Ok();
        }

        // GET: api/Transaction
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TransactionViewModel>>> GetTransactions(int id)
        {
            var transactions = await _repositoryWrapper.TransactionRepository.FindByCondition(r => r.CakeId == id).ToListAsync();
            var transactionsViewModels = _mapper.Map<List<TransactionViewModel>>(transactions);
            return transactionsViewModels;
        }

    }
}