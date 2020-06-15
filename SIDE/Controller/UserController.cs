using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIDE.Dto.Users;
using SIDE.Service.user;

namespace SIDE.Controller
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

        [HttpGet]
        [ProducesResponseType(typeof(Task<IEnumerable<UserDto>>), StatusCodes.Status200OK)]
        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var users = await _userService.GetAll();

            var dtos = _mapper.Map<IEnumerable<UserDto>>(users);

            return dtos;
        }
    }
}