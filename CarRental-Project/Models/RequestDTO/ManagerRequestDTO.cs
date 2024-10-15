namespace CarRental_Project.Models.RequestDTO
{
    public class ManagerRequestDTO
    {
        public string Title { get; set; }
        public int Regnumber { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public string EngineCapacity { get; set; }
        public string Mileage { get; set; }
        public decimal PricePerDay { get; set; }
        public string Color { get; set; }
        public IFormFile ImageFile { get; set; }  // Image upload
    }
}
