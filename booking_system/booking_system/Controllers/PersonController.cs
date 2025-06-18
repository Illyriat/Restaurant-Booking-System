using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booking_system.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // GET: Person
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public PersonController(ApplicationDBContext dbcontext)
        {
            context = dbcontext;
        }


        // GET: PersonController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var Person = context.Persons.Where(l => l.Id == id).Single();
            return Ok(Person);
        }
    }
}