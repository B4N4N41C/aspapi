using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace student
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DBContext _context = new DBContext();
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students;
        }
         // GET api/<AutoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AutoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
