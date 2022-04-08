using Newtonsoft.Json;
namespace FruitApi.Services.Models
{
    public class FruitInfo
    {
        public FruitName Name { get; set; }
        public FruitCategorisation Categorisation { get; set; }           
        public FruitNutrition Nutrition { get; set; }   
        
    }
}
