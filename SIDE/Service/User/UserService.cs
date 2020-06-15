using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIDE.Model;

namespace SIDE.Service.user
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Получить список пользователей
        /// </summary>
        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await GetUsersQuery().ToListAsync();

            return users;
        }

        public IQueryable<User> GetUsersQuery()
        {
            var result = _dataContext.Users;

            return result;
        }
    }
}