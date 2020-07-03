using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuckTaleSolutionTask.Models;
using DuckTaleSolutionTask.Models.Entities;
using DuckTaleSolutionTask.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DuckTaleSolutionTask.Models.Service
{
    public class StudentService : IStudentService

    {
        private readonly IStudentRepository _studentRepository;

        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
        }


        public async Task<List<Student>> ListAsync(DatatableFilter datatableFilter = null)
        {
            return _studentRepository.ListAsync(datatableFilter);
        }


        public async Task<ResponseStatus> SaveAsync(Student student)
        {
            try
            {
                await _studentRepository.AddAsync(student);
                await _unitOfWork.CompleteAsync();

                return new ResponseStatus("", student.Id > 0 ? true : false);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ResponseStatus($"An error occurred when saving the category: {ex.Message}", false);
            }
        }


        public async Task<ResponseStatus> UpdateAsync(int id, Student student)
        {
            try
            {

                _studentRepository.Update(id, student);
                var updateStatus = await _unitOfWork.CompleteAsync();

                if (updateStatus > 0)
                    return new ResponseStatus("Update Successfully", true);


            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ResponseStatus("Could not updated." + ex.Message, false);
            }

            return new ResponseStatus("Could not updated.", false);
        }


        public async Task<ResponseStatus> DeleteAsync(int id)
        {
            var existingStudent = await _studentRepository.FindByIdAsync(id);

            if (existingStudent == null)
                return new ResponseStatus("Student could not be found.", false);

            try
            {
                _studentRepository.Delete(existingStudent);
                var updateStatus = await _unitOfWork.CompleteAsync();

                if (updateStatus > 0)
                    return new ResponseStatus("Deleted Successfully", true);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ResponseStatus("Could not updated." + ex.Message, false);
            }

            return new ResponseStatus("Student could not be deleted!", false);
        }

        public int TotlaRecords(DatatableFilter datatableFilter = null)
        {
            return _studentRepository.TotalRecords(datatableFilter);
        }
    }
}