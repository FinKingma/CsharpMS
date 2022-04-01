using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace DiscServiceTest
{
    public class A_ComponentTestsRead : AbstractComponentTests
    {
        [Fact]
        public async Task IcanGetARandomCard()
        {
            var card = await _client.GetStringAsync("/api/cards/random");

            Assert.NotNull(card);
        }

        [Fact]
        public async Task IcanGetASpecificCardWhichIsAlwaysBlue()
        {
            var card = await _client.GetStringAsync("/api/cards/1");

            Assert.NotNull(card);
            Assert.Contains("BLUE", card);
        }

        [Fact]
        public async Task IHaveThirtySixCards()
        {
            var jsonString = await _client.GetStringAsync("/api/cards");
            var cards = JsonConvert.DeserializeObject<List<JObject>>(jsonString);

            Assert.NotNull(cards);
            Assert.Equal(36, cards?.Count);
        }
    }
}
