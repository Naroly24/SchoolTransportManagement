using SchoolTransportManagement.Domain;
using SchoolTransportManagement.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolTransportManagement.Application.Services
{
    public class ConductorService
    {
        private readonly ApplicationDbContext _context;

        public ConductorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Conductor>> GetConductoresAsync()
        {
            return await _context.Conductores.ToListAsync();
        }

        public async Task<Conductor> GetConductorByIdAsync(int id)
        {
            return await _context.Conductores.FindAsync(id);
        }

        public async Task<Conductor> AddConductorAsync(Conductor conductor)
        {
            _context.Conductores.Add(conductor);
            await _context.SaveChangesAsync();
            return conductor;
        }

        public async Task<Conductor> UpdateConductorAsync(Conductor conductor)
        {
            _context.Conductores.Update(conductor);
            await _context.SaveChangesAsync();
            return conductor;
        }

        public async Task<bool> DeleteConductorAsync(int id)
        {
            var conductor = await _context.Conductores.FindAsync(id);
            if (conductor == null)
            {
                return false;
            }

            _context.Conductores.Remove(conductor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
