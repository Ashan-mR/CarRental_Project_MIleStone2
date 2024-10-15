using CarRental_Project.IRepositories;
using CarRental_Project.IServices;

namespace CarRental_Project.Services
{
    public class ManagerServices:IManagerServices
    {
        private readonly IManagerRepository _managerRepository;

        public ManagerServices(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }
    }
}
