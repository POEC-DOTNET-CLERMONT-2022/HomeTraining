using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _repository { get; }
        private IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _repository = userRepository;
            _mapper = mapper;
        }


        // GET: api/<UserController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserDto>))]
        public ActionResult<IEnumerable<UserDto>>? Get()
        {
            var users = _repository.GetAllUsers();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(usersDto);
        }


        // GET api/<UserController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UserDto> Get(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            UserEntity userGet = _repository.GetSingleUser(id);
            if (userGet == null)
                return NotFound("Aucun resultat pour GET");
            UserDto userDto = _mapper.Map<UserDto>(userGet);
            return Ok(userDto);
        }


        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<UserDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UserDto> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            UserEntity userEntity = _repository.RemoveUser(id);
            if (userEntity == null)
                return NotFound("Aucun resultat pour DEL");
            UserDto exerciceDto = _mapper.Map<UserDto>(userEntity);
            return Ok(exerciceDto);
        }


        //POST api/<UserController>        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<UserDto>))]
        public ActionResult<UserDto> Post([FromBody] UserEntity userEntity)
        {
            //TODO verifier les informations passées
            _repository.AddUser(userEntity);
            UserDto userDto = _mapper.Map<UserDto>(userEntity);
            return Ok(userDto);
        }


        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<UserDto>))]
        public ActionResult<UserDto> Put([FromBody] UserEntity userEntity)
        {
            //TODO verifier les informations passées
            UserEntity majuserEntity = _repository.UpdateUser(userEntity);
            if (majuserEntity == null)
                return NotFound("Aucun resultat pour PUT");
            UserDto userDto = _mapper.Map<UserDto>(majuserEntity);
            return Ok(userDto);
        }


    }
}
