using AutoMapper;
using Ipme.Hometraining.DTO;
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
            _repository = new ExerciceRepository(dbContext);
            _mapper = mapper;
        }


        // GET: api/<ExerciceController>
        [HttpGet]
        public IEnumerable<ExerciceEntity>? Get()
        {
            return _repository.GetAllExercices();
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


            // GET api/<ExerciceController>/5
        [HttpGet("{id}/descriptionnnn")]
        public ActionResult<string> GetDesc(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }
            ExerciceEntity exerciceEntity = _repository.GetSingleExercice(id);
            return exerciceEntity.Description;
        }



        // DELETE api/<ExerciceController>/5
        [HttpDelete("{id}")]
        public ActionResult<ExerciceDto> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }
            ExerciceEntity exerciceEntity = _repository.RemoveExercice(id);
            ExerciceDto exerciceDto = _mapper.Map<ExerciceDto>(exerciceEntity);
            _dbContext.SaveChanges();
            return Ok(exerciceDto);
        }

        //POST api/<ExerciceController>
        //TODO verifier les informations passées
        [HttpPost]
        public ExerciceEntity Post([FromBody] ExerciceEntity exerciceEntity)
        {
            _repository.AddExercice(exerciceEntity);
            _dbContext.SaveChanges();
            return exerciceEntity;
        }

        // PUT api/<ExerciceController>/5
        //TODO implémenter la mise à jour
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //PUT your code here
        }




    }
}
