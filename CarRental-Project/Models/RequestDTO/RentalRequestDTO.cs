namespace CarRental_Project.Models.RequestDTO
{
    public class RentalRequestDTO
    {
        public Guid CustomerID { get; set; }
        public Guid CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime Returndate { get; set; }
        public decimal Totalrentalcost { get; set; }
        public bool IsinsuraceIncluded { get; set; } = true;
        public decimal latefee { get; set; }
        public string status { get; set; } = "Rent";
    }
}
