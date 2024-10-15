using CarRental_Project.Entities;

namespace CarRental_Project.Models.ResponseDTO
{
    public class RentalResponseDTO
    {
        public Guid id { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime Returndate { get; set; }
        public bool Isoverdue { get; set; }
        public bool Paymentstatus { get; set; }
        public decimal Totalrentalcost { get; set; }
        public bool IsinsuraceIncluded { get; set; }
        public string status { get; set; }
        public Customer Customer { get; set; }
        public Car Cars { get; set; }
    }
}
