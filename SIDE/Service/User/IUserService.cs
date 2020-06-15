using System.Collections.Generic;
using System.Threading.Tasks;
using SIDE.Model;

namespace SIDE.Service.user
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
    }
}