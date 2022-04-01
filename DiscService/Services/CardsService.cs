using DiscService.Services.Interfaces;

namespace DiscService
{
    class CardsService: ICardsService
    {
        private static readonly List<Card> cards = new List<Card>
        {
            new Card(1, CardColor.BLUE, "Hoge eisen"),
            new Card(2, CardColor.BLUE, "Analytisch"),
            new Card(3, CardColor.BLUE, "Perfectionist"),
            new Card(4, CardColor.BLUE, "Gericht op procedures"),
            new Card(5, CardColor.BLUE, "Gesloten"),
            new Card(6, CardColor.BLUE, "Formeel"),
            new Card(7, CardColor.BLUE, "Zoekt naar feiten"),
            new Card(8, CardColor.BLUE, "Bedachtzaam"),
            new Card(9, CardColor.BLUE, "Nauwkeurig"),
            new Card(10, CardColor.GREEN, "Begripvol"),
            new Card(11, CardColor.GREEN, "Teamspeler"),
            new Card(12, CardColor.GREEN, "Betrouwbaar"),
            new Card(13, CardColor.GREEN, "Geduldig"),
            new Card(14, CardColor.GREEN, "Vriendelijk"),
            new Card(15, CardColor.GREEN, "Bescheiden"),
            new Card(16, CardColor.GREEN, "Belangstellend"),
            new Card(17, CardColor.GREEN, "Loyaal"),
            new Card(18, CardColor.GREEN, "Goede luisteraar"),
            new Card(19, CardColor.YELLOW, "Ongedwongen"),
            new Card(20, CardColor.YELLOW, "Inspirerend"),
            new Card(21, CardColor.YELLOW, "Hartelijk"),
            new Card(22, CardColor.YELLOW, "In voor nieuwe ideeen"),
            new Card(23, CardColor.YELLOW, "Optimistisch"),
            new Card(24, CardColor.YELLOW, "Houdt van gezelschap"),
            new Card(25, CardColor.YELLOW, "Spraakzaam"),
            new Card(26, CardColor.YELLOW, "Enthousiast"),
            new Card(27, CardColor.YELLOW, "Impulsief"),
            new Card(28, CardColor.RED, "Beslisser"),
            new Card(29, CardColor.RED, "Avontuurlijk"),
            new Card(30, CardColor.RED, "Gericht op uitdagingen"),
            new Card(31, CardColor.RED, "Doelgericht"),
            new Card(32, CardColor.RED, "Snel"),
            new Card(33, CardColor.RED, "Neemt de leiding"),
            new Card(34, CardColor.RED, "Direct"),
            new Card(35, CardColor.RED, "Zelfverzekerd"),
            new Card(36, CardColor.RED, "Ongeduldig"),
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

        public Card draw()
        {
            if (cards.Count > 0)
            {
                var randomNumber = _random.Next(0, cards.Count);
                var pickedCard = cards[randomNumber];
                cards.Remove(pickedCard);
                return pickedCard;
            }
            throw new Exception("No cards found");
        }

        public Card getCard(int id)
        {
            return cards.First(x => x.Id == id);
        }

        public void addCard(Card card)
        {
            cards.Add(card);
        }
    }
}
