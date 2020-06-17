using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Models;

namespace SIDE.Configures
{
    /// <summary>
    /// Конфигурация для сущности <see cref="User"/>
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        /// <summary>
        /// Конфигурация для сущности <see cref="User"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.Property(x => x.Id).HasComment("Идентификатор пользователя").UseIdentityByDefaultColumn();

            builder.Property(x => x.Email).HasComment("Электронная почта");
            builder.Property(x => x.FirstName).HasComment("Имя");
            builder.Property(x => x.Login).HasComment("Логин");
            builder.Property(x => x.PassHash).HasComment("Хеш пароля");

            builder
                .HasMany(x => x.Characters)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.UserId);
        }
    }
}