using BloodBankManagement.Core.Entities;

namespace BloodBankManagement.Core.Interfaces.Repositories
{
    public interface IDonatorRepository
    {
        Donator GetDonatorById(int id);
        int CreateDonator(Donator donator);
    }
}