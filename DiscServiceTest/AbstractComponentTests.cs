using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace DiscServiceTest
{
    public abstract class AbstractComponentTests
    {
        protected HttpClient _client;
        public AbstractComponentTests()
        {
            var application = new WebApplicationFactory<Program>();
            _client = application.CreateClient();
        }
    }
}
