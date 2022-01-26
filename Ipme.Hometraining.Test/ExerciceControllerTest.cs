using APIRest.Controllers;
using AutoMapper;
using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Persistance;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;
using Serilog.Core;

namespace Ipme.Hometraining.Test
{
    [TestClass]
    public class ExerciceControllerTest
    {
        private ExercicesController ExercicesController { get; set; }
        private IExerciceRepository ExericiceRepository { get; set; }
        private IMapper Mapper { get; set; }
        //TODO injecter serilog
        private Logger _log{ get; set; } 

    public ExerciceControllerTest()
        {            
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(ExercicesController)));
            Mapper = new Mapper(configuration);
        }

        [TestInitialize]
        public void InitTest()
        {
            ExericiceRepository = new ExerciceSqlRepository();
            _log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            ExercicesController = new ExercicesController(ExerciceRepository, Mapper, Logger);
        }

        [TestMethod]
        public void TestGetAllUsers_Ok()
        {
            #region Arrange
            #endregion

            #region Act
            var result = UsersController.Get();
            #endregion


            #region Assert            
            var okResult = result as OkObjectResult;
            okResult.Should().NotBeNull();
            var entities = okResult?.Value as IEnumerable<UserDto>;
            entities.Should().NotBeNull();
            entities.Count().Should().Be(15);
            #endregion
        }


        [TestMethod]
        public void TestGetAllUsers_NullRepository()
        {
            //Arrange
            UsersController = new UsersController(null, Mapper, Logger);


            //Act
            var result = UsersController.Get();

            //Assert
            var statusResult = result as StatusCodeResult;
            statusResult.Should().NotBeNull();
            statusResult.StatusCode.Should().Be((int)HttpStatusCode.InternalServerError);
        }

        
    }
}