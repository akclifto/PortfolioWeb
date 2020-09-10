using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PortfolioWeb.Model;
using PortfolioWeb.Services;
using System.Collections.Generic;

namespace PortfolioWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //create a JsonFileSectionService object
        public JsonFileSectionService SectionService;
        //put the object from the json file in a list.
        public IEnumerable<Section> SectionList { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileSectionService sectionService)
        {
            _logger = logger;
            SectionService = sectionService;
        }

        public void OnGet()
        {
            SectionList = SectionService.GetSections();
        }
    }
}