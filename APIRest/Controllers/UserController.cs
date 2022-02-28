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
        IExerciceRepository _exosRepository { get; }
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepository userRepository, IMapper mapper, IExerciceRepository exosRepository, ILogger<UserController> Logger)
        {
            _repository = userRepository;
            _mapper = mapper;
            _exosRepository = exosRepository;
            _logger = Logger;
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
            _logger.LogInformation($"\n >>> User Get method called with params: id={id} \n");

            if (id == Guid.Empty)
                return NotFound();
            UserEntity userGet = _repository.GetSingleUser(id);
            if (userGet == null)
            {
                _logger.LogError($"\n >>> User Id {id} not found \n");
                return NotFound("Aucun resultat pour GET");
            }
            UserDto userDto = _mapper.Map<UserDto>(userGet);

            _logger.LogInformation($"\n >>> User id={id} name={userDto.FirstName} read \n");

            return Ok(userDto);
        }


        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<UserDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<UserDto> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();

            var exos = _exosRepository.GetExercicesOfUser(id);
            if (exos.Count() > 0)
                return Unauthorized("Il existe des exercices. DEL impossible");

            //TODO vérifier si user a des Programmes

            UserEntity userEntity = _repository.RemoveUser(id);
            if (userEntity == null)
                return NotFound("Aucun resultat pour DEL. User n'existe pas");

            UserDto exerciceDto = _mapper.Map<UserDto>(userEntity);
            return Ok(exerciceDto);
        }


        //POST api/<UserController>        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<UserDto>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<UserDto> Post([FromBody] UserEntity userEntity)
        {
            //TODO verifier les informations passées

            UserEntity userGet = _repository.GetSingleUser(userEntity.Id);
            if (userGet != null)
                return Unauthorized("Id existe deja. POST impossible");

            if (userEntity.Login == null)
                return Unauthorized("Login obligatoire. POST impossible");

            if (userEntity.LastName == null)
                return Unauthorized("Nom obligatoire. POST impossible");

            _repository.AddUser(userEntity);
            UserDto userDto = _mapper.Map<UserDto>(userEntity);
            return Ok(userDto);
        }


        // PUT api/<UserController>/5
        // [HttpPut("{id}")] pas de Id en param? deja dans le FromBody
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<UserDto>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<UserDto> Put([FromBody] UserEntity userEntity)
        {
            //TODO verifier les informations passées

            if (userEntity.Login == null)
                return Unauthorized("Login obligatoire. MAJ impossible");

            if (userEntity.LastName == null)
                return Unauthorized("Nom obligatoire. MAJ impossible");

            UserEntity majuserEntity = _repository.UpdateUser(userEntity);
            if (majuserEntity == null)
                return NotFound("Aucun resultat pour PUT");

            UserDto userDto = _mapper.Map<UserDto>(majuserEntity);
            return Ok(userDto);
        }


    }
}
