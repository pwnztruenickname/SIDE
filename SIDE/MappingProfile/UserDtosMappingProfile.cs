using AutoMapper;
using SIDE.Dto.Users;
using SIDE.Model;

namespace SIDE.MappingProfile
{
    public class UserDtosMappingProfile : Profile
    {
        public UserDtosMappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}