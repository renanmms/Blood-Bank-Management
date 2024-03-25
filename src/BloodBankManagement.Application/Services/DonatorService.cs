using BloodBankManagement.Core.Entities;
using BloodBankManagement.Core.Interfaces.Repositories;
using BloodBankManagement.Core.Interfaces.Services;

namespace BloodBankManagement.Application.Services
{
    public class DonatorService : IDonatorService
    {
        private readonly IDonatorRepository _donatorRepository;

        public DonatorService(IDonatorRepository donatorRepository)
        {
            _donatorRepository = donatorRepository;
        }

        public int CreateDonator(Donator donator)
        {
            return _donatorRepository.CreateDonator(donator);
        }

        public Donator GetDonatorById(int id)
        {
            return _donatorRepository.GetDonatorById(id);
        }
    }
}