using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FirstApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController: ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> getValues(){
            var values = await _context.values.ToListAsync();
            return Ok(values);
        }

        [Route("{id}")]
        public async Task<IActionResult> getValues(int id){
            var value = await _context.values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

    }
}