using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class DetailIncidenceConfiguration : IEntityTypeConfiguration<DetailIncidence>
{
    public void Configure(EntityTypeBuilder<DetailIncidence> builder)
    {
        builder.ToTable("DetailIncidence");
        builder.Property(p => p.Id_DetailIncidence).IsRequired();
        builder.Property(p => p.Id_Peripheral).IsRequired();
        builder.Property(p => p.Id_TypeIncidence).IsRequired();
        builder.Property(p => p.Id_LevelIncidence).IsRequired();
        builder.Property(p => p.Id_State).IsRequired();
        builder.Property(p => p.Description_DetailIncidence).IsRequired().HasMaxLength(100);
    }
}