using System.Text.Json;
using System.Text.Json.Serialization;

namespace PortfolioWeb.Model
{
    public class Section
    {
        /// <summary>
        /// A Numerical way to define section information within the web portfolio
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of each specific tab relating to each
        /// </summary>
        public string Tab { get; set; }

        /// <summary>
        /// The name of each section
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Corresponding body of text for each section title.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Items specified in list, in form of array.
        /// </summary>
        public string[] BulletList { get; set; }

        /// <summary>
        /// Image used for various sections in the portfolio.
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