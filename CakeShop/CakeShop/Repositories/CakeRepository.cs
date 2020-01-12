using CakeShop.Data;
using CakeShop.Models;

namespace CakeShop.Repositories
{
    public class CakeRepository : RepositoryBase<Cake>, ICakeRepository
    {
        public CakeRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }
    }
}
