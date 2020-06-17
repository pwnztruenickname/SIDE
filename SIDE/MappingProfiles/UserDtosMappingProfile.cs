using AutoMapper;
using SIDE.Dtos.Users;
using SIDE.Models;

namespace SIDE.MappingProfiles
{
    public class UserDtosMappingProfile : Profile
    {
        public UserDtosMappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}