using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booking_system.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        // GET: TableController

        private readonly ApplicationDBContext context;
        public TableController(ApplicationDBContext dbcontext)
        {
            context = dbcontext;
        }

        // GET: TableController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var Table = context.RestaurantTables.Where(l => l.Id == id).Single();
            return Ok(Table);
        }
    }
}
