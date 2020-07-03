using DuckTaleSolutionTask.Models;
using DuckTaleSolutionTask.Models.Entities;
using DuckTaleSolutionTask.Models.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DuckTaleSolutionTask.Models.Interfaces

{
    public interface IStudentService
    {

        Task<List<Student>> ListAsync(DatatableFilter datatableFilter = null);

        int TotlaRecords(DatatableFilter datatableFilter = null);

        Task<ResponseStatus> SaveAsync(Student oCategory);

        Task<ResponseStatus> UpdateAsync(int id, Student category);

        Task<ResponseStatus> DeleteAsync(int id);


    }
}