
namespace CarRental_Project.IRepositories
{
    public interface ICustomerRepository
    {
        Task GetCustomerByID(Guid id);
    }
}
