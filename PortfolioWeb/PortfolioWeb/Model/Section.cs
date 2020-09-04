using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PortfolioWeb.Model
{
    public class Section
    {
        /// <summary>
        /// Id: Numerical way to define sections within the web portfolio
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Tab: The name of each specific tab relating to each 
        /// </summary>
        public string Tab { get; set; }
        /// <summary>
        /// Title: The name of each section
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description: Corresponding body of text for each section title.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Image: image uses for various sections in the portfolio.
        /// Not every section will contain an image.
        /// </summary>
        [JsonPropertyName("img")]
        public string Image { get; set; }

        /// <summary>
        /// Override ToString: to serialize a JSON file.
        /// </summary>
        /// <returns>Serialized string of Section information.</returns>
        public override string ToString() => JsonSerializer.Serialize<Section>(this);
    }
}
