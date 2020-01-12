using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        ICakeRepository CakeRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        IReviewRepository ReviewRepository { get; }

        ITransactionRepository TransactionRepository { get; }

        void Save();
    }
}
