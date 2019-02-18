using Microsoft.AspNetCore.Mvc;
using Moq;
using MyCoreAPIDemo.Controllers;
using MyCoreAPIDemo.Entities;
using MyCoreAPIDemo.Repository.Contract;
using System;
using Xunit;

namespace MyCoreAPIDemoTest
{
    public class LibrariesControllerTest
    {

        public LibrariesController Controller { get; set; }
        private readonly Mock<ILibraryRepository<Author>> mocRepo;
        public LibrariesControllerTest()
        {
            mocRepo = new Mock<ILibraryRepository<Author>>();
            Controller = new LibrariesController(mocRepo.Object);
        }
        [Fact]
        public void GetAllAuthor_Return_Ok()
        {
            //Arrange 
            var result = Controller.GetAllAuthor();
            //ACT
            var okResult = result as OkObjectResult;
            //Assert
            Assert.IsType<OkObjectResult>(okResult);


        }
    }
}
