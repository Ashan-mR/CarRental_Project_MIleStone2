using CarRental_Project.Data;
using CarRental_Project.IRepositories;

namespace CarRental_Project.Repositories
{
    public class ManagerRepository:IManagerRepository
    {
        private readonly CarRentalDBContext _dbContext;

        public ManagerRepository(CarRentalDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
