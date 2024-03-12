using System;

namespace BloodBankManagement.Core.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonatorId { get; set; }
        public DateTime DonationDate { get; set; }
        public int AmountML { get; set; }
        public Donator? Donator { get; set; }
    }
}