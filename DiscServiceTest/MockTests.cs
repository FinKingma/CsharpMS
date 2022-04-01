using DiscService;
using DiscService.Controllers;
using DiscService.Services;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace DiscServiceTest
{
    public class MockTests
    {
        [Fact]
        public void ICanMockWhatTheControllerAsks()
        {
            var mockService = new Mock<ICardsService>();
            var mockedData = new List<Card>
            {
                new Card(CardColor.BLUE, "Hoge eisen"),
                new Card(CardColor.BLUE, "Analytisch")
            };
            mockService.Setup(cardService => cardService.getAll()).Returns(mockedData);

            CardsController cardsController = new CardsController(null, mockService.Object);
            List<Card> actual = cardsController.GetAll();
            Assert.Equal(2, actual.Count);
        }
    }
}
