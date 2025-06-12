using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

namespace ConsoleNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;
        private readonly Random _random;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
            _random = new Random();
        }

        [HttpGet]
        [Route("GetRNG/{amount}")]
        public IEnumerable<int> GetRNG(int amount, int maxValue = 10)
        {
            return Enumerable.Range(1, amount).Select(x => _random.Next(maxValue));
        }
    }
}
