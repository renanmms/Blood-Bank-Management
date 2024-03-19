using BloodBankManagement.Core.Entities;

namespace BloodBankManagement.Core.Interfaces.Repositories
{
    public interface IDonatorRepository
    {
        int CreateDonator(Donator donator);
    }
}