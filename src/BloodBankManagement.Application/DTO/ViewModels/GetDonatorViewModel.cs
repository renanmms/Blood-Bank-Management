using System;

namespace BloodBankManagement.Application.DTO.ViewModels
{
    public record GetDonatorViewModel(string? Email, 
        string? Fullname, 
        DateTime BirthDate,
        string? Gender,
        double Weight, 
        string? BloodType,
        string? RhFactor);
}