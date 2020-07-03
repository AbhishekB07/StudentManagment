using DuckTaleSolutionTask.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DuckTaleSolutionTask.Models.Interfaces
{
    public interface IStudentRepository
    {
        //Task<ResponseStatus> Add(Student user, ICollection<Subject> subjects);
        //Task<ResponseStatus> Update(Student user, ICollection<Subject> subjects);
        //Task<ResponseStatus> Remove(Student user, ICollection<Subject> subjects);
        //Task<ResponseStatus> FindById(int studentId);

        List<Student> ListAsync(DatatableFilter datatableFilter = null);
        Task<Student> FindByIdAsync(int id);
        Task AddAsync(Student category);
        void Update(int id, Student student);
        void Delete(Student oCategory);
        int TotalRecords(DatatableFilter datatableFilter = null);
    }
}