using Newtonsoft.Json;
namespace FruitApi.Services.Models
{
    public class FruitNutrition
    {
        [JsonProperty("per")]
        public string Per { get; set; }

        [JsonProperty("cals")]
        public string Cals { get; set; }

        [JsonProperty("protein")]
        public string Protein { get; set; }

        [JsonProperty("fat")]
        public string Fat { get; set; }

        [JsonProperty("sugar")]
        public string Sugar { get; set; }

        [JsonProperty("carbs")]
        public string Carbs { get; set; }
    }
}
