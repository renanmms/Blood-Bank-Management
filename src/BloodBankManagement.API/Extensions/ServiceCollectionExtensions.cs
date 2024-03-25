using BloodBankManagement.Application.Services;
using BloodBankManagement.Core.Interfaces.Repositories;
using BloodBankManagement.Core.Interfaces.Services;
using BloodBankManagement.Infra.Repositories;

namespace Blood_Bank_ManagementBloodBankManagement.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDonatorRepository, DonatorRepository>();
        }

        public static void AddBaseServices(this IServiceCollection services)
        {
            services.AddScoped<IDonatorService, DonatorService>();
        }
    }
}