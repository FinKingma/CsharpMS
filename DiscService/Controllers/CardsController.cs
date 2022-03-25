using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace DiscService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ILogger<CardsController> _logger;
        private CardsService _cardsService;

        public CardsController(ILogger<CardsController> logger, CardsService cardsService)
        {
            _logger = logger;
            _cardsService = cardsService;
        }

        [HttpGet(Name = "getAll")]
        public List<Card> GetAll()
        {
            return _cardsService.getAll();
        }
    }
}