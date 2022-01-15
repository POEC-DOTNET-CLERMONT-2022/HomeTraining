using AutoMapper;
using Ipme.Hometraining.DTO;
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
        private readonly DbContext _dbContext;
        private IMapper _mapper;

        public UserController(SqlDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _repository = new UserRepository(dbContext);
            _mapper = mapper;
        }




        //POST api/<UserController>
        //TODO verifier les informations passées
        [HttpPost]
        public UserEntity Post([FromBody] UserEntity userEntity)
        {
            _repository.AddUser(userEntity);
            _dbContext.SaveChanges();
            return userEntity;
        }




    }
}
