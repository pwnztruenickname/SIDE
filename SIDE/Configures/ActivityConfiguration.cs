using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Models;

namespace SIDE.Configures
{
    /// <summary>
    /// Конфигурация для сущности <see cref="Activity"/>
    /// </summary>
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        /// <summary>
        /// Конфигурация для сущности <see cref="Activity"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("activities");

            builder.Property(x => x.Id).UseIdentityByDefaultColumn();

            builder.Property(x => x.AllianceId).HasComment("Идентификатор альянса");
            builder.Property(x => x.Name).HasComment("Название мероприятия");
            builder.Property(x => x.ActivityDateTime).HasComment("Дата проведения мероприятия");
            builder.Property(x => x.OrganiserId).HasComment("Идентификатор организатора мероприятия");

            builder.Property(o => o.ActivityType)
                .IsRequired()
                .HasMaxLength(50)
                .HasConversion<string>()
                .HasComment("Тип мероприятия");

            builder
                .HasMany(x => x.CharacterActivities)
                .WithOne(x => x.Activity)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ActivityId);
        }
    }
}