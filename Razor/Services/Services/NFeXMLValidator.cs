using Razor.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Razor.Services.Services
{
    public class NFeXMLValidator : INFeXMLValidator
    {
        private readonly HttpClient _client;
        private readonly IConfiguration Configuration;

        public NFeXMLValidator(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            Configuration = configuration;
            this.Setup();
        }

        private void Setup()
        {
            _client.BaseAddress = new Uri(Configuration.GetSection("Api").GetSection("Address").Value);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<HttpResponseMessage> Validate(string XML)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync<string>(_client.BaseAddress, XML);

            return response;
        }
    }
}
