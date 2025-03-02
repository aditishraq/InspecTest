using InspecTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InspecTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public PersonsController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAll()
        {
            return await _db.Persons.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Person>> Create(Person person)
        {
            _db.Persons.Add(person);
            await _db.SaveChangesAsync();
            return Ok(person);
        }
    }
}
