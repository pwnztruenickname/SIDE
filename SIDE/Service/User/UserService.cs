using System;
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
        public async Task<IEnumerable<Character>> GetUserCharacters(long id)
        {
            var users = await GetCurrentUser(id);

            return users.Characters;
        }

        public async Task<User> GetCurrentUser(long id)
        {
            var user = await GetUsersQuery()
                .SingleOrDefaultAsync(x => x.Id == id);

            if (user == null)
                throw new Exception($"Пользователя с идентификатором \"{id}\" не найдено");

            return user;
        }
 
        public IQueryable<User> GetUsersQuery()
        {
            var result = _dataContext.Users
                .Include(x => x.Characters);

            return result;
        }
    }
}