using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class IncidenceConfiguration : IEntityTypeConfiguration<Incidence>
{
    public void Configure(EntityTypeBuilder<Incidence> builder)
    {
        builder.ToTable("Incidence");
        builder.Property(p => p.Id_Incidence).IsRequired();
        builder.Property(p => p.Id_User).IsRequired();
        builder.Property(p => p.Id_State).IsRequired();
        builder.Property(p => p.Id_Area).IsRequired();
        builder.Property(p => p.Id_Place).IsRequired();
        builder.Property(p => p.Date).IsRequired().HasColumnType("Date");
        builder.Property(p => p.Description_Incidence).IsRequired().HasMaxLength(100);
    }
}