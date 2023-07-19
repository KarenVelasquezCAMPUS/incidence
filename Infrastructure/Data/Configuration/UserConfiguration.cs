using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");
        builder.Property(p => p.Id_User).IsRequired();
        builder.Property(p => p.Name_User).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Lastname_User).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Address_User).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Id_DocumentType).IsRequired();
        builder.Property(p => p.Id_Rol).IsRequired();
    }
}