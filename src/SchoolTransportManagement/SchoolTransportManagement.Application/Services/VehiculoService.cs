using SchoolTransportManagement.Domain;
using SchoolTransportManagement.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolTransportManagement.Application.Services
{
    public class VehiculoService
    {
        private readonly ApplicationDbContext _context;

        public VehiculoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Vehiculo>> GetVehiculosAsync()
        {
            return await _context.Vehiculos.ToListAsync();
        }

        public async Task<Vehiculo> GetVehiculoByIdAsync(int id)
        {
            return await _context.Vehiculos.FindAsync(id);
        }

        public async Task<Vehiculo> AddVehiculoAsync(Vehiculo vehiculo)
        {
            _context.Vehiculos.Add(vehiculo);
            await _context.SaveChangesAsync();
            return vehiculo;
        }

        public async Task<Vehiculo> UpdateVehiculoAsync(Vehiculo vehiculo)
        {
            _context.Vehiculos.Update(vehiculo);
            await _context.SaveChangesAsync();
            return vehiculo;
        }

        public async Task<bool> DeleteVehiculoAsync(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return false;
            }

            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
