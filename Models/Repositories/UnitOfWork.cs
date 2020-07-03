using DuckTaleSolutionTask.Models.Context;
using DuckTaleSolutionTask.Models.Interfaces;
using System.Threading.Tasks;

namespace DuckTaleSolutionTask.Models.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
