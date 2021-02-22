using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorTourOfHeros.Shared;

namespace BlazorTourOfHeros.Client.Services
{
    public interface IHeroService
    {
        Task<Hero[]> GetHeroes();
    }
}
