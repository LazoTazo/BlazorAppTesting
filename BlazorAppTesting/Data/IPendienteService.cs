using BlazorAppTesting.Models;

namespace BlazorAppTesting.Data
{
    public interface IPendienteService
    {
        Task<IEnumerable<Pendiente>> GetPendientes();
        Task<Pendiente> GetPendienteDetails(int id);
        Task<bool> InsertPendiente(Pendiente pendiente);
        Task<bool> UpdatePendiente(Pendiente pendiente);
        Task<bool> DeletePendiente(int id);
        Task<bool> SavePendiente(Pendiente pendiente);
    }
}
