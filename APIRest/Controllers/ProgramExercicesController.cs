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
    public class ProgramExercicesController : ControllerBase
    {
        IProgramExerciceRepository _repository { get; }
        private IMapper _mapper;
        private readonly ILogger<ProgramExercicesController> _logger;

        public ProgramExercicesController(IProgramExerciceRepository repository, IMapper mapper, ILogger<ProgramExercicesController> Logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = Logger;
        }


        // GET: api/<ProgramExercicesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProgramExerciceDto>))]
        public IActionResult Get()
        {
            var prgExercices = _repository.GetAllProgramExercices();
            var prgExercicesDto = _mapper.Map<IEnumerable<ProgramExerciceDto>>(prgExercices);
            return Ok(prgExercicesDto);
        }


        // GET api/<ProgramExercicesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProgramExerciceDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProgramExerciceDto> Get(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            ProgramExerciceEntity prgExGet = _repository.GetSingleProgramExercice(id);
            if (prgExGet == null)
                return NotFound("Aucun resultat pour GET");
            ProgramExerciceDto prgExDto = _mapper.Map<ProgramExerciceDto>(prgExGet);
            return Ok(prgExDto);
        }


        // DELETE api/<ProgramExercicesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ProgramExerciceDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProgramExerciceDto> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();
            ProgramExerciceEntity prgExEntity = _repository.RemoveProgramExercice(id);
            if (prgExEntity == null)
                return NotFound("Aucun resultat pour DEL");
            ProgramExerciceDto prgExDto = _mapper.Map<ProgramExerciceDto>(prgExEntity);
            return Ok(prgExDto);
        }


        //POST api/<ProgramExercicesController>        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ProgramExerciceDto>))]
        public ActionResult<ProgramExerciceDto> Post([FromBody] ProgramExerciceDto prgExDto)
        {
            //TODO verifier les informations passées
            ProgramExerciceEntity prgExEntity = _mapper.Map<ProgramExerciceEntity>(prgExDto);
            _repository.AddProgramExercice(prgExEntity);
            return Ok(prgExDto);
        }


        // PUT api/<ProgramExercicesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ActionResult<ProgramExerciceDto>))]
        public ActionResult<ProgramExerciceDto> Put([FromBody] ProgramExerciceDto prgExDto)
        {
            //TODO verifier les informations passées
            ProgramExerciceEntity prgExEntity = _mapper.Map<ProgramExerciceEntity>(prgExDto);
            ProgramExerciceEntity majPrgExEntity = _repository.UpdateProgramExercice(prgExEntity);
            if (majPrgExEntity == null)
                return NotFound("Aucun resultat pour PUT");
            return Ok(prgExDto);
        }


        // GET: api/<ProgramExercicesController>/ProgramId
        [HttpGet("ProgramId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProgramExerciceDto>))]
        public IActionResult GetDetailProgram(Guid programId)
        {
            var prgExercices = _repository.GetDetailProgram(programId);
            var prgExercicesDto = _mapper.Map<IEnumerable<ProgramExerciceDto>>(prgExercices);
            return Ok(prgExercicesDto);
        }


    }
}
