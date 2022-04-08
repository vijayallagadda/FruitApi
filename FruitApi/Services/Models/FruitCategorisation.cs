using Newtonsoft.Json;
namespace FruitApi.Services.Models
{
    public class FruitCategorisation
    {
        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }
    }
}
