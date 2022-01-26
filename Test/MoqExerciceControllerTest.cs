using APIRest.Controllers;
using AutoFixture;
using AutoMapper;
using FluentAssertions;
using Ipme.Hometraining.Dto;
using Ipme.Hometraining.Entities;
using Ipme.Hometraining.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Ipme.Hometraining.Test
{
    [TestClass]
    public class MoqExerciceControllerTest
    {
        private ExercicesController ExercicesController { get; set; }
        public Mock<IExerciceRepository> ExerciceRepository { get; set; }
        public IMapper Mapper { get; set; }
        public ILogger<ExercicesController> Logger { get; set; } = new NullLogger<ExercicesController>();
        private Fixture Fixture { get; set; } = new Fixture();
        private IEnumerable<ExerciceEntity> Exercices { get; set; }


        public MoqExerciceControllerTest()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(ExercicesController)));
            Mapper = new Mapper(configuration);
        }

        [TestInitialize]
        public void InitTest()
        {
            Fixture = new Fixture();
            Exercices = Fixture.CreateMany<ExerciceEntity>(10);
            ExerciceRepository = new Mock<IExerciceRepository>();
            ExercicesController = new ExercicesController(ExerciceRepository.Object, Mapper, Logger);
        }

        [TestMethod]
        public void TestGetAllExercices_Ok()
        {
            //Arrange
            ExerciceRepository.Setup(repo => repo.GetAllExercices()).Returns(Exercices);
            //
            ExerciceRepository.Setup(repo => repo.AddExercice(It.IsAny<ExerciceEntity>()))
                .Throws(new Exception("test unitaire"));

            //Act
            var result = ExercicesController.Get();

            //Assert
            var okResult = result as OkObjectResult;
            okResult.Should().NotBeNull();
            var entities = okResult?.Value as IEnumerable<ExerciceDto>;
            entities.Should().NotBeNull();
            entities.Count().Should().Be(10);

            ExerciceRepository.Verify(repo => repo.GetAllExercices(), Times.Exactly(1));
        }


        [TestMethod]
        public void TestGetAllUsers_NullRepository()
        {
            //Arrange
            ExercicesController = new ExercicesController(null, Mapper, Logger);


            //Act
            var result = ExercicesController.Get();

            //Assert
            var statusResult = result as StatusCodeResult;
            statusResult.Should().NotBeNull();
            statusResult.StatusCode.Should().Be((int)HttpStatusCode.InternalServerError);
        }
    }
}