using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class AreaUserConfiguration : IEntityTypeConfiguration<AreaUser>
{
    public void Configure(EntityTypeBuilder<AreaUser> builder)
    {
        builder.ToTable("AreaUser");
        builder.Property(p => p.Id_AreaUser).IsRequired();
        builder.Property(p => p.Id_Area).IsRequired();
        builder.Property(p => p.Id_User).IsRequired();
    }
}