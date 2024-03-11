using System;

namespace BloodBankManagement.Core.Entities
{
    public class BloodStock
    {
        public int Id { get; set; }
        public string? BloodType { get; set; }
        public string? RhFactor { get; set; }
        public int AmountML { get; set; }
    }
}