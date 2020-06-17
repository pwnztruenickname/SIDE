using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Models;

namespace SIDE.Configures
{
    /// <summary>
    /// Конфигурация для промежуточной таблицы между сущностями <see cref="Character"/> и <see cref="Activity"/>
    /// </summary>
    public class CharacterActivityConfiguration : IEntityTypeConfiguration<CharacterActivity>
    {
        public void Configure(EntityTypeBuilder<CharacterActivity> builder)
        {
            builder.ToTable("character_activities");

            builder.Property(x => x.Id);
            builder.Property(x => x.ActivityId).HasComment("Идентифкатор мероприятия");
            builder.Property(x => x.CharacterId).HasComment("Идентифкатор персонажа");

            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterActivities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.CharacterId);

            builder
                .HasOne(x => x.Activity)
                .WithMany(x => x.CharacterActivities)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ActivityId);
        }
    }
}