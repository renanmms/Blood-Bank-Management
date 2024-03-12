namespace BloodBankManagement.Core.Entities
{
    public class Donator
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Fullname { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Gender { get; set; }
        public double Weight { get; set; }
        public string? BloodType { get; set; }
        public string? RhFactor { get; set; }
        public List<Donation>? Donations { get; set; }
        public Address? Address { get; set; }
    }
}