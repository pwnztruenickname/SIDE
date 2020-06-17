using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIDE.Models;

namespace SIDE.Configures
{
    /// <summary>
    /// Конфигурация для <see cref="Class"/>
    /// </summary>
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        /// <summary>
        /// Конфигурация для <see cref="Class"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("classes");

            builder.Property(x => x.Id).UseIdentityByDefaultColumn();
            builder.Property(x => x.Name).HasComment("Наименование класса");
        }
    }
}