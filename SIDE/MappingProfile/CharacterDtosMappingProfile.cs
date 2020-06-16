using AutoMapper;
using SIDE.Dto.Characters;
using SIDE.Model;

namespace SIDE.MappingProfile
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