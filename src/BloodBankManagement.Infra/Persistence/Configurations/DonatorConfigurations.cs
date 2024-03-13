using BloodBankManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodBankManagement.Infra.Persistence.Configurations
{
    public class DonatorConfigurations : IEntityTypeConfiguration<Donator>
    {
        public void Configure(EntityTypeBuilder<Donator> builder)
        {
            builder.HasMany(d => d.Donations)
                .WithOne(d => d.Donator)
                .HasForeignKey(d => d.DonatorId)
                .HasPrincipalKey(d => d.Id)
                .IsRequired();

            builder.HasOne(d => d.Address)
                .WithOne(d => d.Donator)
                .HasForeignKey<Address>(d => d.DonatorId)
                .IsRequired();
        }
    }
}