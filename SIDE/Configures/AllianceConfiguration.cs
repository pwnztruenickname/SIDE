using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Models;

namespace SIDE.Configures
{
    /// <summary>
    /// Конфигурация для сущности <see cref="Alliance"/>
    /// </summary>
    public class AllianceConfiguration : IEntityTypeConfiguration<Alliance>
    {
        /// <summary>
        /// Конфигурация для сущности <see cref="Alliance"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Alliance> builder)
        {
            builder.ToTable("alliances");

            builder.Property(x => x.Id).UseIdentityByDefaultColumn();

            builder.Property(x => x.Name).HasComment("Наименование альянса");

            builder
                .HasMany(x => x.Characters)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.AllianceId);

            builder
                .HasMany(x => x.Activities)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.AllianceId);
        }
    }
}