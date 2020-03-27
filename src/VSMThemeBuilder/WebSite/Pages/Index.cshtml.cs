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

namespace VSMThemeBuilder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public string CSharpSampleHtml { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
            HtmlRenderer renderer = new HtmlRenderer
            {
                IncludeLineNumbers = true
            };

            string pathToTemplate = Path.Combine(_webHostEnvironment.ContentRootPath, "Templates/CSharpSample.cs");
            CSharpSampleHtml = renderer.Render(System.IO.File.ReadAllText(pathToTemplate));
        }
    }
}