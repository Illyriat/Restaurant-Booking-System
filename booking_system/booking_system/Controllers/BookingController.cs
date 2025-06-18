using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booking_system.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BookingController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public BookingController(ApplicationDBContext dbcontext)
        {
            context = dbcontext;
        }


        // GET: BookingController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var Booking = context.Bookings.Where(l => l.Id == id).Single();
            return Ok(Booking);
        }
    }
}
