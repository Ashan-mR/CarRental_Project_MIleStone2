﻿namespace CarRental_Project.Entities
{
    public class Management
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string NIC { get; set; }
        public bool IsActive { get; set; }
        public DateTime Dateofhire { get; set; }

    }
}
