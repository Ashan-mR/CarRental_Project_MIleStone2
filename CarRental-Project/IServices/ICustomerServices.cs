using CarRental_Project.Models.ResponseDTO;

namespace CarRental_Project.IServices
{
    public interface ICustomerServices
    {
        Task<CustomerResponseDTO> GetCustomerByID(Guid id);
    }
}
