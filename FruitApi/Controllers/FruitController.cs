using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FruitApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        [HttpGet]
        [Route("{fruit}")]
        public async Task<IActionResult> Get([FromRoute] string fruit)
        {
            var c = new HttpClient();

            var apiData = await (await c.SendAsync(new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new System.Uri("https://fruitinfo.azurewebsites.net/api/Info?name=" + fruit)
                }))
                .Content.ReadAsStringAsync(); 

            var data = JObject.Parse(apiData);

            var apiData2 = await (await c.SendAsync(new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new System.Uri("http://fruitnutritions.azurewebsites.net/api/nutritions?type=" + fruit)
                }))
                .Content.ReadAsStringAsync();

            var returnData = new
            {
                name = data.SelectToken("name").ToString(),
                categorisation = new
                {
                    genus = data.SelectToken("genus").ToString(),
                    family = data.SelectToken("family").ToString()
                },
                nutritions = apiData2
            };

            return new OkObjectResult(returnData);
        }
    }
}
