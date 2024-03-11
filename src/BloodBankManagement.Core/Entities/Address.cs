using System;

namespace BloodBankManagement.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? CEP { get; set; }
        public Donator? Donator { get; set; }
    }
}