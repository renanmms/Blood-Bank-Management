using System;
using BloodBankManagement.Core.Entities;

namespace BloodBankManagement.Core.Interfaces.Services
{
    public interface IDonatorService
    {
        Donator GetDonatorById(int id);
        int CreateDonator(Donator donator);
    }
}