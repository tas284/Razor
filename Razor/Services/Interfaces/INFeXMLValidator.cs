namespace Razor.Services.Interfaces
{
    public interface INFeXMLValidator
    {
        public Task<HttpResponseMessage> Validate(string XML);
    }
}
