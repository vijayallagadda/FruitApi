using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FruitApi.Services.Models;
using FruitApi.Services;
using Microsoft.Extensions.Logging;

namespace FruitApi.Services
{
    public class FruitService
    {
        public async Task<object> GetFruitAsync(string fruit)
        {    
            try
            {
                // Consuming Json data from provided url //
                var fruitInfo = JObject.Parse(await GetInfo($"{Constant.FruitInfoUrl}?name={fruit}"));
                var fruitNutritionData = JObject.Parse(await GetInfo($"{Constant.FruitNutritionsUrl}?type={fruit}"));
                return new
                {
                    // The Input Json is mapped as single confined record for Fruit info and its nutrition.
                    // Here the driving factor is the Name field.
                    // For different family and genus of fruit and nutrition values, we need to have overlap fields in 
                    // nutrition Json so that we can map the results with fruit info and nutrition.
                    // If so then the below code need to be expanded to consume list of objects.
                    Name = new FruitName
                    {
                        Name = fruitInfo.SelectToken("name").ToString()
                    },
                    Categorisation = new FruitCategorisation
                    {
                        Genus = fruitInfo.SelectToken("genus").ToString(),
                        Family = fruitInfo.SelectToken("family").ToString()
                    },
                    Nutrition = new FruitNutrition
                    {
                        Per = fruitNutritionData.SelectToken("per").ToString(),
                        Cals = fruitNutritionData.SelectToken("cals").ToString(),
                        Protein = fruitNutritionData.SelectToken("protein").ToString(),
                        Fat = fruitNutritionData.SelectToken("fat").ToString(),
                        Sugar = fruitNutritionData.SelectToken("sugar").ToString(),
                        Carbs = fruitNutritionData.SelectToken("carbs").ToString()
                    }
                };

            }                        
            catch (Exception)
            { 
                // TODO: Need to expand exception logic to segregate all the exceptions and logging.
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }
        public async Task<string> GetInfo(string url)
        {   
            // To be more clean , we can move this seperate class.
            var c = new HttpClient();
            var apiData = await (await c.SendAsync(new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{url}")
            })).Content.ReadAsStringAsync();
            return apiData;
        }
    }
}