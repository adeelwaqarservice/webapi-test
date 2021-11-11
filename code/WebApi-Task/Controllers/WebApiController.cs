using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using WebApi_Task.Models.Interfaces;

namespace WebApi_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebApiController : ControllerBase
    {
        private readonly ILogger<WebApiController> _logger;
        private readonly AppConfig _config;
        private readonly IWebRepository _repo;

        public WebApiController(ILogger<WebApiController> logger, AppConfig config, IWebRepository repo)
        {
            _logger = logger;
            _config = config;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInformation("Started preparing data on GET");
                var data = _repo.GetWebsiteData();
                //Return number of navigation links based on the configuration
                if (data?.Header?.NavigationLinks?.Count() > _config?.MaxNavigationLinks)
                {
                    data.Header.NavigationLinks = data?.Header?.NavigationLinks?.Take(_config.MaxNavigationLinks);
                }
                _logger.LogInformation($"Returning data GET {data}");
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception: {ex} -- Message: {ex.Message} -- StackTrace: {ex.StackTrace} -- InnerException: {ex.InnerException}");
                throw;
            }
        }
    }
}
