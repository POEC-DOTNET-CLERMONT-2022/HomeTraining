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

    public class ProgramController : ControllerBase
    {
        IProgramRepository _repository { get; }
        private readonly DbContext _dbContext;
        private IMapper _mapper;

        public ProgramController(SqlDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _repository = new ProgramSqlRepository(dbContext);
            _mapper = mapper;
        }


        // GET: api/<ProgramController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProgramDto>))]
        public ActionResult<IEnumerable<ProgramDto>>? Get()
        {
            var programs = _repository.GetAllPrograms();
            var programsDto = _mapper.Map<IEnumerable<ProgramDto>>(programs);
            return Ok(programsDto);
        }


        // GET api/<ProgramController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProgramDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProgramDto> Get(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            ProgramEntity programGet = _repository.GetSingleProgram(id);
            if (programGet == null)
                return NotFound("Aucun resultat pour GET");
            ProgramDto programDto = _mapper.Map<ProgramDto>(programGet);
            return Ok(programDto);
        }

        // DELETE api/<ProgramController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ProgramDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProgramDto> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            ProgramEntity programEntity = _repository.RemoveProgram(id);
            if (programEntity == null)
                return NotFound("Aucun resultat pour DEL");
            ProgramDto programDto = _mapper.Map<ProgramDto>(programEntity);
            _dbContext.SaveChanges();
            return Ok(programDto);
        }


        //POST api/<ProgramController>        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ProgramDto>))]
        public ActionResult<ProgramDto> Post([FromBody] ProgramDto programDto)
        {
            //TODO verifier les informations passées
            ProgramEntity programEntity = _mapper.Map<ProgramEntity>(programDto);
            _repository.AddProgram(programEntity);
            _dbContext.SaveChanges();
            return Ok(programDto);
        }


        // PUT api/<ProgramController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ProgramDto>))]
        public ActionResult<ProgramDto> Put([FromBody] ProgramDto programDto)
        {
            //TODO verifier les informations passées
            ProgramEntity programEntity = _mapper.Map<ProgramEntity>(programDto);
            ProgramEntity majprogramEntity = _repository.UpdateProgram(programEntity);
            if (majprogramEntity == null)
                return NotFound("Aucun resultat pour PUT");
            _dbContext.SaveChanges();
            return Ok(programDto);

        }


    }


}
