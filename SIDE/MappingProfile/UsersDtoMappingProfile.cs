using AutoMapper;
using SIDE.Dto.Users;
using SIDE.Model;

namespace SIDE.MappingProfile
{
    public class UsersDtoMappingProfile : Profile
    {
        public UsersDtoMappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}