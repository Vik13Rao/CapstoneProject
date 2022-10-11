using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    
    public class MedicinesController : BaseApiController
    {
        private readonly StoreContext _context;

        public MedicinesController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Medicine>>> GetMedicines()
        {
           return await _context.Medicines.ToListAsync();
            
        }

        [HttpGet("{id}")]
        public  async Task<ActionResult<Medicine>> GetMedicine(int id)
        {
            return await _context.Medicines.FindAsync(id);
        }
    }
}
