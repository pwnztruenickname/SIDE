using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIDE.Dtos.Characters;
using SIDE.Services.user;

namespace SIDE.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class UserController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Task<IEnumerable<CharacterDto>>), StatusCodes.Status200OK)]
        public async Task<IEnumerable<CharacterDto>> GetUserCharacters(long id)
        {
            var characters = await _userService.GetUserCharacters(id);

            var dtos = _mapper.Map<IEnumerable<CharacterDto>>(characters);

            return dtos;
        }
    }
}