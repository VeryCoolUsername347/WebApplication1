using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/Pokemon")]
    public class PokemonController : ControllerBase
    {
        private static List<Pokemon> pList = new List<Pokemon>()
        {
            new Pokemon() {Name = "Pikachu"},
            new Pokemon() {Name = "Bulbasaur"}
        };

    [HttpGet]
        public ActionResult<List<Pokemon>> Get()
        {
            

            return Ok(pList);            
        }
    }
}