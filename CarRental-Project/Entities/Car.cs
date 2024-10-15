namespace CarRental_Project.Entities
{
    public class Car
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }  // File path instead of byte array
        public int Regnumber { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public string EngineCapacity { get; set; }
        public string Mileage { get; set; }
        public decimal PricePerDay { get; set; }
        public string Color { get; set; }
        public DateTime LastServicedDate { get; set; }
    }
}
