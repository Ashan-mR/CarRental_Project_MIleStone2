using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace CarRental_Project.Entities
{
    public class Rental
    {
        public Guid id { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime Returndate { get; set; }
        public bool Isoverdue { get; set; } = false;
        public bool Paymentstatus { get; set; }
        public decimal Totalrentalcost { get; set; }
        public bool IsinsuraceIncluded { get; set; } = false;
        public decimal latefee { get; set; }
        public string status { get; set; } = "Rent";
        public Customer Customer { get; set; }
        public Car Cars { get; set; }
    }
}
