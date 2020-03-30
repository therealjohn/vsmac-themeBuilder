using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Levaro.CSharp.Display.Renderers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace VSMThemeBuilder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public string CSharpSampleHtml { get; set; }
        public List<string> Scopes { get; set; } = new List<string>();

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            Scopes.Clear();

            HtmlRenderer renderer = new HtmlRenderer
            {
                IncludeLineNumbers = true,
                AlternateLines = false,
                IncludeDebugInfo = true
            };

            string pathToTemplate = Path.Combine(_webHostEnvironment.ContentRootPath, "Templates/CSharpSample.cs");
            CSharpSampleHtml = renderer.Render(System.IO.File.ReadAllText(pathToTemplate));

            string pathToJson = Path.Combine(_webHostEnvironment.ContentRootPath, "Config/config.json");
            var o = JObject.Parse(System.IO.File.ReadAllText(pathToJson));

            foreach(var scope in o["elements"])
            {
                Scopes.Add(scope.ToString());
            }

            foreach (var scope in o["textElements"])
            {
                Scopes.Add(scope.ToString());
            }
        }
    }
}