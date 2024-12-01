using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace student
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentMarkController : ControllerBase
    {
        private readonly DBContext _context = new DBContext();
        [HttpGet]
        public IEnumerable<StudentMark> Get()
        {
            return _context.StudentMarks;
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
