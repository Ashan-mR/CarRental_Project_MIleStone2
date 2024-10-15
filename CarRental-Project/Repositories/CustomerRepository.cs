using CarRental_Project.Data;
using CarRental_Project.IRepositories;

namespace CarRental_Project.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly CarRentalDBContext _dbContext;

        public CustomerRepository(CarRentalDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
