
using DuckTaleSolutionTask.Models.Context;

namespace DuckTaleSolutionTask.Models.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
