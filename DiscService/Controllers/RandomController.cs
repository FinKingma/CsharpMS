using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace DiscService.Controllers
{
    [ApiController]
    [Route("Cards/random")]
    public class RandomController : ControllerBase
    {
        private readonly ILogger<RandomController> _logger;
        private CardsService _cardsService;

        public RandomController(ILogger<RandomController> logger, CardsService cardsService)
        {
            _logger = logger;
            _cardsService = cardsService;
        }

        [HttpGet(Name = "getRandom")]
        public Card getRandom()
        {
            return _cardsService.getRandom();
        }
    }
}