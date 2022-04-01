using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscServiceTest
{
    public class B_ComponentTestsDraw : AbstractComponentTests
    {
        [Fact]
        public async Task ICanDrawACardAndReduceThePile()
        {
            var jsonString2 = await _client.GetStringAsync("/api/cards/draw");
            var card = JsonConvert.DeserializeObject<JObject>(jsonString2);
            Assert.NotNull(card);

            var jsonString3 = await _client.GetStringAsync("/api/cards");
            var cards = JsonConvert.DeserializeObject<List<JObject>>(jsonString3);
            Assert.Equal(35, cards?.Count);
        }
    }
}
