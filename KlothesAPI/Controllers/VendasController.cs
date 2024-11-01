using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KlothesAPI.Data;
using KlothesAPI.Models;

namespace KlothesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Vendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendas>>> GetVendas()
        {
            return await _context.Vendas.ToListAsync();
        }

        // GET: api/Vendas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendas>> GetVendas(Guid id)
        {
            var vendas = await _context.Vendas.FindAsync(id);

            if (vendas == null)
            {
                return NotFound();
            }

            return vendas;
        }

        // PUT: api/Vendas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendas(Guid id, Vendas vendas)
        {
            if (id != vendas.Id)
            {
                return BadRequest();
            }

            _context.Entry(vendas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vendas>> PostVendas(Vendas vendas)
        {
            _context.Vendas.Add(vendas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendas", new { id = vendas.Id }, vendas);
        }

        // DELETE: api/Vendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendas(Guid id)
        {
            var vendas = await _context.Vendas.FindAsync(id);
            if (vendas == null)
            {
                return NotFound();
            }

            _context.Vendas.Remove(vendas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendasExists(Guid id)
        {
            return _context.Vendas.Any(e => e.Id == id);
        }
    }
}
