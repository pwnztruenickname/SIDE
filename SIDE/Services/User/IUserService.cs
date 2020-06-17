using System.Collections.Generic;
using System.Threading.Tasks;
using SIDE.Models;

namespace SIDE.Services.user
{
    public interface IUserService
    {
        Task<IEnumerable<Character>> GetUserCharacters(long id);

        Task<User> GetCurrentUser(long id);
    }
}