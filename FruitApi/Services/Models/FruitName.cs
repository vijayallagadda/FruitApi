using Newtonsoft.Json;
namespace FruitApi.Services.Models
{
    public class FruitName
    {
        [JsonProperty("name", Required = Required.DisallowNull)]
        public string Name { get; set; }
    }
}
