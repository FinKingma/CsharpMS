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
    public class C_ComponentTestsCreate : AbstractComponentTests
    {
        [Fact]
        public async Task IcanAddANewCard()
        {
            string card = "{\"Id\": 37, \"CardColor\": \"GREEN\", \"Text\": \"Braaf\"}";
            HttpContent content = new StringContent(card, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/api/cards", content);
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);


            var storedCard = await _client.GetStringAsync("/api/cards/37");

            Assert.NotNull(storedCard);
        }
    }
}
