using DiplomskiV3.Data;
using DiplomskiV3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DiplomskiV3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly BazaContext _context;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,BazaContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<Movie>> GetAsync()
        {
            IEnumerable<Movie> a = _context.Movie.ToList();

            return a;
        }
        [HttpPost("PostMovie")]
        public async Task<IEnumerable<Movie>> Post(Movie a)
        {
            Console.WriteLine("goriiiiiiiiiiiiiiiii");
            Console.WriteLine(a.Title);
            List<Movie> t = new();
            Movie t1 =new();
            t1.Title = "raid seve";
            t.Add(t1);
            t.Add(a);
          
            IEnumerable <Movie> ai =t;
            return ai;
        }
    }
}