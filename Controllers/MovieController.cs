using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modul9_1302210128.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> film = new List<Movie>()
        {
            new Movie("The Shawshank Redemption",  "Frank Darabont",  new List<string>(){"Tim Robbins", "Morgan Freeman", "Bob Gunton"}, "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit."),
            new Movie("The Godfather",  "Frank Darabont",  new List<string>(){"Marlon Brando", "Al Pacino", "James Caan"},  "The Godfather 'Don' Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WW II Marine is also present at the wedding"),
            new Movie( "The Dark Knight",  "Christopher Nolan",  new List<string>(){"Christian Bale", "Heath Ledger", "Aaron Eckhart"},  "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as 'The Joker' appears in Gotham, creating a new wave of chaos.") 
        };

        [HttpGet]
        public IEnumerable<Movie> GET()
        {
            return film;
        }

        [HttpPost]
        public void Post([FromBody] Movie ada)
        {
            film.Add(ada);
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return film[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            film.RemoveAt(id);
        }
    }


}
