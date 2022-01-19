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
        private readonly DbContext _dbContext;
        private IMapper _mapper;

        public ExercicesController(SqlDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _repository = new ExerciceSqlRepository(dbContext);
            _mapper = mapper;
        }


        // GET: api/<ExerciceController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExerciceDto>))]
        public ActionResult<IEnumerable<ExerciceDto>>? Get()
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
            {
                return NotFound();
            }
            ExerciceEntity exerciceEntity = _repository.GetSingleExercice(id);
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
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
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
            if (exerciceEntity == null)
                return NotFound("Aucun resultat");
            _dbContext.SaveChanges();
            return Ok(exerciceDto);
        }

        //POST api/<ExerciceController>        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ExerciceDto>))]
        public ActionResult<ExerciceDto> Post([FromBody] ExerciceEntity exerciceEntity)
        {
            //TODO verifier les informations passées
            _repository.AddExercice(exerciceEntity);
            _dbContext.SaveChanges();
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
            return Ok(exerciceDto);
        }

        // PUT api/<ExerciceController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ExerciceDto>))]
        public ActionResult<ExerciceDto> Put([FromBody] ExerciceEntity exerciceEntity)
        {
            //TODO verifier les informations passées
            ExerciceEntity majexerciceEntity = _repository.UpdateExercice(exerciceEntity);
            if (majexerciceEntity == null)
                return NotFound();
            _dbContext.SaveChanges();
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(majexerciceEntity);
            return Ok(exerciceDto);
        }

    }
}
