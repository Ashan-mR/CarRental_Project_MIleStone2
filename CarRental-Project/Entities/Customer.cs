namespace CarRental_Project.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Mobilenumber { get; set; }
        public string Address { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int Licence { get; set; }
        public int Nic { get; set; }
        public string Password { get; set; }
        public DateTime licence_exprydate { get; set; }
        public ICollection<Rental> Rental_history { get; set; }
        public string Paymentmethod { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
