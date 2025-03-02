using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using InspecTest.Data;

namespace InspecTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ExamsController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/Exams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exam>>> GetAll()
        {
            var exams = await _db.Exams
                .Include(e => e.Questions)
                .ToListAsync();

            return Ok(exams); // Return ActionResult
        }

        // GET: api/Exams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> Get(int id)
        {
            var exam = await _db.Exams
                .Include(e => e.Questions)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (exam == null) return NotFound();
            return Ok(exam);
        }

        // POST: api/Exams
        [HttpPost]
        public async Task<ActionResult<Exam>> Create(Exam exam)
        {
            _db.Exams.Add(exam);
            await _db.SaveChangesAsync();
            return Ok(exam);
        }

        // ...Update, Delete, etc.
    }
}
