using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioWeb.Model;
using PortfolioWeb.Services;
using System.Collections.Generic;

namespace PortfolioWeb.Pages
{
    public class ProjectsModel : PageModel
    {
        public JsonFileSectionService SectionService;
        public IEnumerable<Section> SectionList { get; private set; }

        public ProjectsModel(JsonFileSectionService sectionService)
        {
            SectionService = sectionService;
        }
        public void OnGet()
        {
            SectionList = SectionService.GetSections();
        }
    }
}