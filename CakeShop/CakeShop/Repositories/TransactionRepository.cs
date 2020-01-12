using CakeShop.Data;
using CakeShop.Models;
using CakeShop.Repositories.Interfaces;

namespace CakeShop.Repositories
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
