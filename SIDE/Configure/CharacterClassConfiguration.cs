using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Model;

namespace SIDE.Configure
{
    public class CharacterClassConfiguration : IEntityTypeConfiguration<CharacterClass>
    {
        public void Configure(EntityTypeBuilder<CharacterClass> builder)
        {
            builder.ToTable("character_classes");

            builder.Property(x => x.Id);
            builder.Property(x => x.CharacterId).HasComment("Идентификатор персонажа");
            builder.Property(x => x.ClassId).HasComment("Идентификатор класса");
            builder.Property(x => x.Level).HasComment("Уровень прокаченности класса у персонажа");

            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterClasses)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.CharacterId);

            builder
                .HasOne(x => x.Class)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.CharacterId);

            builder.HasIndex(x => new {x.CharacterId, x.ClassId}).IsUnique();
        }
    }
}