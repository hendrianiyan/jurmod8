using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mod8_1302200104.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie : ControllerBase
    {
        private string[] arrTopmovie = new[]
        {
             "title": "The Shawshank Redemption",
             "director": "Frank Darabont",
             "star":
            [
                "Tim Robbins",
                "Morgan Freeman",
                "Bob Gunton",
            ],
            "description" :"Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency"
        },
        {
            "title": "The Godfather",
             "director": "Francis Ford Coppola",
             "star":
            [
                "Marlon Brando",
                "Al Pacino",
                "James Caan",
            ],
            "description" :"The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son"
         },
         {
             "title": " The Dark Knight",
             "director": "Christopher Nolan",
             "star":
            [
                "Christian Bale",
                "Heath Ledger",
                "Aaron Eckhart",
            ],
             "description": "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
         };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return arrTopmovie;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return arrTopmovie[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
