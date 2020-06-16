using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Model;

namespace SIDE.Configure
{
    /// <summary>
    /// Конфигурация для <see cref="Character"/>
    /// </summary>
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        /// <summary>
        /// Конфигурация для <see cref="Character"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.ToTable("characters");

            builder.Property(x => x.Id).UseIdentityByDefaultColumn();
            builder.Property(x => x.Name).HasComment("Наименование персонажа");
            builder.Property(x => x.UserId).HasComment("Идентификатор пользователя");

            builder
                .HasMany(x => x.CharacterClasses)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}