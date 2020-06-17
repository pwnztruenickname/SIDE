using AutoMapper;
using SIDE.Dtos.Characters;
using SIDE.Models;

namespace SIDE.MappingProfiles
{
    public class CharacterDtosMappingProfile : Profile
    {
        public CharacterDtosMappingProfile()
        {
            CreateMap<Character, CharacterDto>()
                .ForMember(x => x.Id, o => o.MapFrom(s => s.Id))
                .ForMember(x => x.Name, o => o.MapFrom(s => s.Name))
                .ForAllOtherMembers(o => o.Ignore());
        }
    }
}