using HaydenWebsite.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaydenWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static string[] Languages = new[]
        {
            "C#", "Python", "Ruby/RoR", "Java", "AngularJS", "jQuery", "Javascript", "Visual Basic"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
        
        [HttpGet("[action]")]
        public IEnumerable<ProgrammingLanguage> ProgrammingLanguages()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ProgrammingLanguage
            {
                Name = Languages[rng.Next(Languages.Length)],
                Rating = rng.Next(1,10)
            });
        }
    }
}
