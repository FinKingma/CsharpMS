using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace DiscServiceTest
{
    public class ComponentTests
    {
        private HttpClient _client;
        public ComponentTests()
        {
            var application = new WebApplicationFactory<Program>();
            _client = application.CreateClient();
        }

        [Fact]
        public async Task IcanGetARandomCardWhichIsAlwaysBlue()
        {
            var card = await _client.GetStringAsync("/cards/random");

            Assert.NotNull(card);
            Assert.Contains("BLUE", card);
        }

        [Fact]
        public async Task IHaveTwoCards()
        {
            var jsonString = await _client.GetStringAsync("/cards");
            var cards = JsonConvert.DeserializeObject<List<JObject>>(jsonString);

            Assert.NotNull(cards);
            Assert.Equal(2, cards?.Count);
        }
    }
}
