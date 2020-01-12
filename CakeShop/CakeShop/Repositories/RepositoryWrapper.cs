using CakeShop.Data;
using CakeShop.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _applicationDbContext;
        private ICakeRepository _cakeRepository;
        private ICategoryRepository _categoryRepository;
        private IReviewRepository _reviewRepository;
        private ITransactionRepository _transactionRepository;

        public ICakeRepository CakeRepository
        {
            get
            {
                if (_cakeRepository == null)
                {
                    _cakeRepository = new CakeRepository(_applicationDbContext);
                }

                return _cakeRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_applicationDbContext);
                }

                return _categoryRepository;
            }
        }

        public IReviewRepository ReviewRepository
        {
            get
            {
                if(_reviewRepository == null)
                {
                    _reviewRepository = new ReviewRepository(_applicationDbContext);
                }

                return _reviewRepository;
            }
        }

        public ITransactionRepository TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository(_applicationDbContext);
                }

                return _transactionRepository;
            }
        }

        public RepositoryWrapper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
