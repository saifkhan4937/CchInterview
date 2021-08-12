using CrawfordClaimsHandler.Api.CoreWebApi.Controllers;
using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using CrawfordClaimsHandler.Api.CoreWebApi.Test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Test.TestController
{
    public class LossTypeControllerTest
    {
        LossTypeController _controller;
        ILossTypeService _service;
        public LossTypeControllerTest()
        {
            _service = new LossTypeServiceFake();
            _controller = new LossTypeController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAsync().Result;
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var result =  _controller.GetAsync().Result.Result as OkObjectResult; ;
            // Assert
            var items = Assert.IsType<List<LossType>>(result.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
