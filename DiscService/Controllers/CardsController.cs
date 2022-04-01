using AutoMapper;
using DiscService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiscService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ILogger<CardsController> _logger;
        private ICardsService _cardsService;

        public CardsController(ILogger<CardsController> logger, ICardsService cardsService)
        {
            _logger = logger;
            _cardsService = cardsService;
        }

        [HttpGet]
        public List<Card> GetAll()
        {
            return _cardsService.getAll();
        }

        [HttpGet("{id}")]
        public Card getCard(int id)
        {
            return _cardsService.getCard(id);
        }

        [HttpGet("random")]
        public Card getRandom()
        {
            return _cardsService.getRandom();
        }

        [HttpGet("draw")]
        public Card drawCard()
        {
            return _cardsService.draw();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void addCard(Card card)
        {
            _cardsService.addCard(card);
        }
    }
}