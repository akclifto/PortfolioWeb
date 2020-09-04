using Microsoft.AspNetCore.Hosting;
using PortfolioWeb.Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PortfolioWeb.Services
{
    public class JsonFileSectionService
    {
        /// <summary>
        /// Constructor to establish webhosting environment.
        /// </summary>
        /// <param name="webHostEnvironment"></param>
        public JsonFileSectionService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        /// <summary>
        /// public get for webHostEnvironment
        /// </summary>
        public IWebHostEnvironment WebHostEnvironment { get; }

        /// <summary>
        /// Get the name of the json file that is storing information.
        /// @!The may be changed to database info at a later date.
        /// </summary>
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,
                    "data", "sections.json");
            }
        }

        /// <summary>
        /// Iterate through json file and read information.
        /// </summary>
        /// <returns>Section information</returns>
        public IEnumerable<Section> GetSections()
        {
            using (var JsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Section[]>(JsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}