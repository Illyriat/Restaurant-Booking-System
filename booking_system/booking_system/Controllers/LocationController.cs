using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booking_system.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // GET: LocationController
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public LocationController(ApplicationDBContext dbcontext) {
            context = dbcontext;
        }


        // GET: LocationController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var Location =  context.Locations.Where(l => l.Id == id).Single();
            return Ok(Location);
        }
    }
}
