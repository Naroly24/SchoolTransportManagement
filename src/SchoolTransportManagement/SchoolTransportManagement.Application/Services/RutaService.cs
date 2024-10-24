using SchoolTransportManagement.Domain;
using SchoolTransportManagement.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolTransportManagement.Application.Services
{
    public class RutaService
    {
        private readonly ApplicationDbContext _context;

        public RutaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ruta>> GetRutasAsync()
        {
            return await _context.Rutas.ToListAsync();
        }

        public async Task<Ruta> GetRutaByIdAsync(int id)
        {
            return await _context.Rutas.FindAsync(id);
        }

        public async Task<Ruta> AddRutaAsync(Ruta ruta)
        {
            _context.Rutas.Add(ruta);
            await _context.SaveChangesAsync();
            return ruta;
        }

        public async Task<Ruta> UpdateRutaAsync(Ruta ruta)
        {
            _context.Rutas.Update(ruta);
            await _context.SaveChangesAsync();
            return ruta;
        }

        public async Task<bool> DeleteRutaAsync(int id)
        {
            var ruta = await _context.Rutas.FindAsync(id);
            if (ruta == null)
            {
                return false;
            }

            _context.Rutas.Remove(ruta);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
