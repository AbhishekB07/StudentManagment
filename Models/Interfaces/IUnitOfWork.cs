using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckTaleSolutionTask.Models.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
    }
}
