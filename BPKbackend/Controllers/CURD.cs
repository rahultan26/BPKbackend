using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BPKbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CURD : ControllerBase
    {
        static List<CURDClass> CURDClasses =new List<CURDClass>();
        // GET: api/<CURD>
        [HttpGet]
        public IEnumerable<CURDClass> Get()
        {
            return CURDClasses;
        }

    

        // POST api/<CURD>
        [HttpPost]
        public void Post([FromBody] CURDClass value)
        {
            CURDClasses.Add(value);
        }

        

      
      
    }
}
