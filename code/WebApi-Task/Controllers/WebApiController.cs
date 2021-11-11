using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace WebApi_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebApiController : ControllerBase
    {
        private readonly ILogger<WebApiController> _logger;
        private readonly AppConfig _config;

        public WebApiController(ILogger<WebApiController> logger, AppConfig config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInformation("Started preparing data on GET");
                var mockData = Mocks.Mocks.GetWebApiMockData();
                //Return number of navigation links based on the configuration
                if (mockData?.Header?.NavigationLinks?.Count() > _config?.MaxNavigationLinks)
                {
                    mockData.Header.NavigationLinks = mockData?.Header?.NavigationLinks?.Take(_config.MaxNavigationLinks);
                }
                _logger.LogInformation($"Returning data GET {mockData}");
                return Ok(mockData);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception: {ex} -- Message: {ex.Message} -- StackTrace: {ex.StackTrace} -- InnerException: {ex.InnerException}");
                throw;
            }
        }
    }
}
