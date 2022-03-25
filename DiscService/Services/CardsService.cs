using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DiscService
{
    public class CardsService
    {
        private static readonly List<Card> cards = new List<Card>
        {
            new Card(CardColor.BLUE, "Hoge eisen"),
            new Card(CardColor.BLUE, "Analytisch")
        };

        // private readonly ILogger<CardsService> _logger;
        private readonly Random _random = new Random();

        public CardsService()
        {

        }

        public List<Card> getAll()
        {
            return cards;
        }

        public Card getRandom()
        {
            if (cards.Count > 0)
            {
                return cards[_random.Next(0, cards.Count)];
            }
            throw new Exception("No cards found");
        }
    }
}
