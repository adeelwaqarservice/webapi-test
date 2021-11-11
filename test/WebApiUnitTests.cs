using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Linq;
using WebApi_Task.Controllers;
using WebApi_Task.Models;
using Xunit;

namespace WebApi_Task.Tests
{
    public class UnitTest
    {
        private readonly WebApiController _controller;

        public UnitTest()
        {
            var logger = new Mock<ILogger<WebApiController>>();
            var appConfig = new Mock<AppConfig>();

            appConfig.SetupProperty(x => x.MaxNavigationLinks, 3);

            _controller = new WebApiController(logger.Object, appConfig.Object);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }


        [Fact]
        public void Get_WhenCalled_CarouselsAreNotEmpty()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);
            Assert.NotEmpty(item?.Carousels);
        }

        [Fact]
        public void Get_WhenCalled_CarouselsInRange1To10()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);

            Assert.NotNull(item?.Carousels);
            Assert.InRange(item.Carousels.Count(), 1, 10);
        }


        [Fact]
        public void Get_WhenCalled_HeaderNotNull()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);
            Assert.NotNull(item?.Header);
        }


        [Fact]
        public void Get_WhenCalled_ReturnsAllNavigationLinks()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);
            Assert.NotEmpty(item?.Header?.NavigationLinks);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOnlyFixedNavigationLinks()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);
            Assert.Equal(3, item?.Header?.NavigationLinks?.Count());
        }

        [Fact]
        public void Get_WhenCalled_IntroTextIsNotNullOrEmpty()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);
            Assert.NotNull(item?.IntroText);
            Assert.NotEmpty(item?.IntroText);
        }

        [Fact]
        public void Get_WhenCalled_IntroHeadingIsNotNullOrEmpty()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var item = Assert.IsType<WebsiteModel>(okResult.Value);
            Assert.NotNull(item?.IntroHeading);
            Assert.NotEmpty(item?.IntroHeading);
        }
    }
}
