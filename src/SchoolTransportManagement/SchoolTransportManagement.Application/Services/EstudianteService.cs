using SchoolTransportManagement.Domain; 
using SchoolTransportManagement.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SchoolTransportManagement.Application.Services
{
    public class EstudianteService
    {
        private readonly ApplicationDbContext _context;

        public EstudianteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiante>> GetEstudiantesAsync()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        public async Task<Estudiante> GetEstudianteByIdAsync(int id)
        {
            return await _context.Estudiantes.FindAsync(id);
        }

        public async Task<Estudiante> AddEstudianteAsync(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }

        public async Task<Estudiante> UpdateEstudianteAsync(Estudiante estudiante)
        {
            _context.Estudiantes.Update(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }

        public async Task<bool> DeleteEstudianteAsync(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);
            if (estudiante == null)
            {
                return false;
            }

            _context.Estudiantes.Remove(estudiante);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
