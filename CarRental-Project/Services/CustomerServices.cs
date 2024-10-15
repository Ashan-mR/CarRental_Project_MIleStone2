using CarRental_Project.IRepositories;
using CarRental_Project.IServices;
using CarRental_Project.Models.ResponseDTO;

namespace CarRental_Project.Services
{
    public class CustomerServices:ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerResponseDTO> GetCustomerByID(Guid id)
        {
            var data = await _customerRepository.GetCustomerByID(id);

            var CustomerObj = new CustomerResponseDTO();
            {
              Id = id,

            }

        }
    }
}
