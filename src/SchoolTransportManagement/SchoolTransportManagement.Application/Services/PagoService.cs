using SchoolTransportManagement.Domain;
using SchoolTransportManagement.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolTransportManagement.Application.Services
{
    public class PagoService
    {
        private readonly ApplicationDbContext _context;

        public PagoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pago>> GetPagosAsync()
        {
            return await _context.Pagos.ToListAsync();
        }

        public async Task<Pago> GetPagoByIdAsync(int id)
        {
            return await _context.Pagos.FindAsync(id);
        }

        public async Task<Pago> AddPagoAsync(Pago pago)
        {
            _context.Pagos.Add(pago);
            await _context.SaveChangesAsync();
            return pago;
        }

        public async Task<Pago> UpdatePagoAsync(Pago pago)
        {
            _context.Pagos.Update(pago);
            await _context.SaveChangesAsync();
            return pago;
        }

        public async Task<bool> DeletePagoAsync(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);
            if (pago == null)
            {
                return false;
            }

            _context.Pagos.Remove(pago);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
