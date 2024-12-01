using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace student
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly DBContext _context = new DBContext();
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _context.Teachers;
        }
         
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
