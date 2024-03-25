using BloodBankManagement.Core.Entities;
using BloodBankManagement.Core.Interfaces.Repositories;
using BloodBankManagement.Infra.Persistence;

namespace BloodBankManagement.Infra.Repositories
{
    public class DonatorRepository : IDonatorRepository
    {
        private readonly BloodBankDbContext _dbContext;

        public DonatorRepository(BloodBankDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual int CreateDonator(Donator donator)
        {
            _dbContext.Donators.Add(donator);
            _dbContext.SaveChanges();

            return donator.Id;
        }

        public Donator GetDonatorById(int id)
        {
            return _dbContext.Donators.SingleOrDefault(d => d.Id == id);
        }
    }
}