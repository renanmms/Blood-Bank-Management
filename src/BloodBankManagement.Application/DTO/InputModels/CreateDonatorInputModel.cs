using System;

namespace BloodBankManagement.Application.DTO.InputModels
{
    public record CreateDonatorInputModel(string? Email,
        string? Fullname,
        DateTime Birthdate,
        string? Gender,
        double Weight,
        string? BloodType,
        string? RhFactor);
}