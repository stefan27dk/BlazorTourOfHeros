using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using BlazorTourOfHeros.Shared;

namespace BlazorTourOfHeros.Server.Controllers
{
    [ApiController]
    [Route("[controller]")] // To acces controller after the Url enter controller name
    public class HeroController : Controller
    {

        private static readonly Hero[] heroes = new[]
        {
          new Hero(){Id = 1, Name ="Hero1"},
          new Hero(){Id = 2, Name ="Hero2"},
          new Hero(){Id = 3, Name ="Hero3"},
          new Hero(){Id = 4, Name ="Hero4"},
          new Hero(){Id = 5, Name ="Hero5"}
        };



        [HttpGet]
        public IEnumerable<Hero> GetHeroes()
        {
            return heroes; 
        }
    }
}
                                           