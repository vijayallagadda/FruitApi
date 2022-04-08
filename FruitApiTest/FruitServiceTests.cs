using FruitApi.Services;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FruitApi.Services.Tools;
using System.Collections.Generic;

namespace FruitApiTest
{
    public class Tests
    {
        [Theory]
        [InlineData("apple")]
        [InlineData("pear")]
        public async Task SuccessfullyGetFruit(string fruit)
        {
            var sut = new FruitService();
            var result = await sut.GetFruitAsync(fruit);
            result.ToString().ShouldNotStartWith("StatusCode");         

        }

        [Theory]
        [InlineData("apples")]
        [InlineData("pears")]
        [InlineData("xyz")]
        [InlineData("")]
        public async Task FailToGetFruit(string fruit)
        {
            var sut = new FruitService();
            var result = await sut.GetFruitAsync(fruit);
            result.ToString().ShouldStartWith("StatusCode");
        }
    }
}