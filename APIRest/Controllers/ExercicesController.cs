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
        public IEnumerable<ExerciceDto>? Get()
        {
            var exercices = _repository.GetAllExercices();
            var exercicesDto = _mapper.Map<IEnumerable<ExerciceDto>>(exercices);
            return exercicesDto;
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
        public ActionResult<ExerciceDto> Delete(Guid id)
        {
            if (id == Guid.Empty)            
                return NotFound();            
            ExerciceEntity exerciceEntity = _repository.RemoveExercice(id);
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
            if (exerciceEntity == null)
                return NotFound();
            _dbContext.SaveChanges();
            return Ok(exerciceDto);
        }

        //POST api/<ExerciceController>
        //TODO verifier les informations passées
        [HttpPost]
        public ExerciceDto Post([FromBody] ExerciceEntity exerciceEntity)
        {
            _repository.AddExercice(exerciceEntity);
            _dbContext.SaveChanges();
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
            return exerciceDto;
        }

        // PUT api/<ExerciceController>/5
        //TODO implémenter la mise à jour
        [HttpPut("{id}")]
        public ActionResult<ExerciceDto> Put([FromBody] ExerciceEntity exerciceEntity)
        {
            ExerciceEntity majexerciceEntity = _repository.UpdateExercice(exerciceEntity);
            if (majexerciceEntity == null)
                return NotFound();
            _dbContext.SaveChanges();
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(majexerciceEntity);
            return Ok(exerciceDto);
        }



    }
}
