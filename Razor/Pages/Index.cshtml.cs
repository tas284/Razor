using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Services.Interfaces;
using System.Net;

namespace Razor.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly INFeXMLValidator _validator;
        public string XML { get; set; }
        public string Result { get; set; }

        public IndexModel(ILogger<IndexModel> logger, INFeXMLValidator validator)
        {
            _logger = logger;
            _validator = validator;
        }

        public void OnGet(string response = "")
        {
            this.Result = response;
            Page();
        }

        public async Task<IActionResult> OnPostAsync(string xml)
        {
            this.XML = xml;

            if (!ModelState.IsValid)
            {
                Page();
            }

            var response = await this._validator.Validate(xml);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                this.Result = response.Content.ReadAsStringAsync().Result;
                var value = this.Result.Replace("\"", "");
                this.OnGet(value);
            }
            else
            {
                this.OnGet("Sistema indisponível, contate o Suporte!");
            }
            
            return Page();
        }
    }
}