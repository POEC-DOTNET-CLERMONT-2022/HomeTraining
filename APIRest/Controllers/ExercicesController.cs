using AutoMapper;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicesController : ControllerBase
    {
        IExerciceRepository _repository { get; }
        private IMapper _mapper;
        private readonly ILogger<ExercicesController> _logger;

        public ExercicesController(IExerciceRepository repository, IMapper mapper, ILogger<ExercicesController> Logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = Logger;
        }


        // GET: api/<ExerciceController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExerciceDto>))]
        public IActionResult Get()
        {
            var exercices = _repository.GetAllExercices();
            var exercicesDto = _mapper.Map<IEnumerable<ExerciceDto>>(exercices);
            return Ok(exercicesDto);
        }


        // GET api/<ExerciceController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ExerciceDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ExerciceDto> Get(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            ExerciceEntity exerciceGet = _repository.GetSingleExercice(id);
            if (exerciceGet == null)
                return NotFound("Aucun resultat pour GET");
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceGet);
            return Ok(exerciceDto);
        }


        // DELETE api/<ExerciceController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ExerciceDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ExerciceDto> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            ExerciceEntity exerciceEntity = _repository.RemoveExercice(id);
            if (exerciceEntity == null)
                return NotFound("Aucun resultat pour DEL");
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
            return Ok(exerciceDto);
        }

         
        //POST api/<ExerciceController>        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ExerciceDto>))]
        public ActionResult<ExerciceDto> Post([FromBody] ExerciceDto exerciceDto)
        {
            //TODO verifier les informations passées
            ExerciceEntity exerciceEntity = _mapper.Map<ExerciceEntity>(exerciceDto);
            _repository.AddExercice(exerciceEntity);
            return Ok(exerciceDto);
        }


        // PUT api/<ExerciceController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ExerciceDto>))]
        public ActionResult<ExerciceDto> Put([FromBody] ExerciceDto exerciceDto)
        {
            //TODO verifier les informations passées
            ExerciceEntity exerciceEntity = _mapper.Map<ExerciceEntity>(exerciceDto);
            ExerciceEntity majexerciceEntity = _repository.UpdateExercice(exerciceEntity);
            if (majexerciceEntity == null)
                return NotFound("Aucun resultat pour PUT");
            return Ok(exerciceDto);
        }


        // GET: api/<ExerciceController>/UserId
        [HttpGet("UserId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExerciceDto>))]
        public IActionResult GetExercicesOfUser(Guid userId)
        {
            var exercices = _repository.GetExercicesOfUser(userId);
            var exercicesDto = _mapper.Map<IEnumerable<ExerciceDto>>(exercices);
            return Ok(exercicesDto);
        }


        // GET: api/<ExerciceController>/programId
        [HttpGet("ProgramId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExerciceDto>))]
        public IActionResult GetExercicesinProgram(Guid programId)
        {
            var exercices = _repository.GetExercicesinProgram(programId);
            var exercicesDto = _mapper.Map<IEnumerable<ExerciceDto>>(exercices);
            return Ok(exercicesDto);
        }


    }
}
