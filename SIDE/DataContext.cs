using Microsoft.EntityFrameworkCore;
using SIDE.Model;

namespace SIDE
{
    public abstract class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}