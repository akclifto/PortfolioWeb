using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioWeb.Model;
using PortfolioWeb.Services;
using System.Collections.Generic;

namespace PortfolioWeb.Pages
{
    public class EducationModel : PageModel
    {
        public JsonFileSectionService SectionService;

        public IEnumerable<Section> SectionList{get; private set;}

        public EducationModel(JsonFileSectionService sectionService)
        {
            SectionService = sectionService;
        }
        public void OnGet()
        {
            SectionList = SectionService.GetSections();
        }
    }
}