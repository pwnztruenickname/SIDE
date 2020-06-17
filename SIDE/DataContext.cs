using Microsoft.EntityFrameworkCore;
using SIDE.Models;

namespace SIDE
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Персонажи
        /// </summary>
        public DbSet<Character> Characters { get; set; }

        /// <summary>
        /// Промежуточная таблица для <see cref="Class"/> и <see cref="Character"/>
        /// </summary>
        public DbSet<CharacterClass> CharacterClasses { get; set; }

        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<Class> Classes { get; set; }
    }
}