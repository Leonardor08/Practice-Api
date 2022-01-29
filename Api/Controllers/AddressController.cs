using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using System.Data.Entity;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly CollegeDBContext _context;

        public AddressController(CollegeDBContext context)
        {
            _context = context;
        }

        //GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddress()
        {
            return await _context.Addresses.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Address>> createAddress(Address Address)
        {
            _context.Addresses.Add(Address);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress", new { id = Address.iD }, Address);
        }

        private bool AddressExist(int id)
        {
            return _context.Addresses.Any(e => e.iD == id);
        }
    }
}
