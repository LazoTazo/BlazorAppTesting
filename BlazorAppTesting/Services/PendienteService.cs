using BlazorAppTesting.Data;
using BlazorAppTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppTesting.Services
{
    public class PendienteService : IPendienteService
    {
        public readonly ApplicationDbContext _context;
        public PendienteService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> DeletePendiente(int id)
        {
            var pendiente = await _context.Pendientes.FindAsync(id);

            _context.Pendientes.Remove(pendiente);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Pendiente> GetPendienteDetails(int id)
        {
            return await _context.Pendientes.FindAsync(id);
        }

        public async Task<IEnumerable<Pendiente>> GetPendientes()
        {
            return await _context.Pendientes.ToListAsync();
        }

        public async Task<bool> InsertPendiente(Pendiente pendiente)
        {
            _context.Pendientes.Add(pendiente);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SavePendiente(Pendiente pendiente)
        {
            if (pendiente.PendienteId > 0)
                return await UpdatePendiente(pendiente);
            else
                return await InsertPendiente(pendiente);
        }

        public async Task<bool> UpdatePendiente(Pendiente pendiente)
        {
            _context.Entry(pendiente).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
