using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DuckTaleSolutionTask.Models.Context;
using DuckTaleSolutionTask.Models.Entities;
using DuckTaleSolutionTask.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DuckTaleSolutionTask.Models.Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        //public Sorting sorting;

        public StudentRepository(AppDbContext context) : base(context)
        {
        }

        public int TotalRecords(DatatableFilter datatableFilter = null)
        {

            try
            {
                if (datatableFilter != null)
                {

                    var Students = _context.Students.ToList();

                    Students.ForEach(st =>
                    {
                        st.Subjects = _context.Subjects.Where(su => su.StudentId == st.Id).ToList();
                        st.Subjects.ForEach(su => su.Student = null);
                    }
                    );

                    //Search
                    if (!String.IsNullOrWhiteSpace(datatableFilter.Search))
                    {
                        Students = Students.Where(st =>
                             st.FirstName.Contains(datatableFilter.Search) ||
                              st.LastName.Contains(datatableFilter.Search) ||
                             st.Class.Contains(datatableFilter.Search) ||
                             st.Subjects.Exists(su => su.SubjectName.Contains(datatableFilter.Search))

                             ).ToList();
                    }


                    //Sorting
                    if (!String.IsNullOrWhiteSpace(datatableFilter.SortColumn))
                    {
                        switch (datatableFilter.SortDirection)
                        {
                            case "asc":
                                {
                                    //var OrderedStudent = from s in Students orderby datatableFilter.SortColumn, s.FirstName select s; 
                                    var OrderedStudent = Sorting.OrderByField<Student>(Students.AsQueryable(), datatableFilter.SortColumn, true).ToList();
                                    Students = OrderedStudent;
                                    break;
                                }
                            case "desc":
                                {
                                    var OrderedStudent = Sorting.OrderByField<Student>(Students.AsQueryable(), datatableFilter.SortColumn, false).ToList();
                                    Students = OrderedStudent;
                                    break;
                                }
                            default:
                                {
                                    var OrderedStudent = from s in Students orderby s.FirstName ascending select s;
                                    Students = OrderedStudent.ToList();
                                    break;
                                }

                        }
                    }
                    else
                    {
                        var OrderedStudent = from s in Students orderby s.FirstName ascending select s;
                        Students = OrderedStudent.ToList();
                    }

                    return Students.Count;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
            return 0;
        }

        public List<Student> ListAsync(DatatableFilter datatableFilter = null)
        {

            try
            {
                if (datatableFilter != null)
                {

                    var Students = _context.Students.ToList();

                    Students.ForEach(st =>
                    {
                        st.Subjects = _context.Subjects.Where(su => su.StudentId == st.Id).ToList();
                        st.Subjects.ForEach(su => su.Student = null);
                    }
                    );

                    //Search
                    if (!String.IsNullOrWhiteSpace(datatableFilter.Search))
                    {
                        Students = Students.Where(st =>
                             st.FirstName.Contains(datatableFilter.Search) ||
                              st.LastName.Contains(datatableFilter.Search) ||
                             st.Class.Contains(datatableFilter.Search) ||
                             st.Subjects.Exists(su => su.SubjectName.Contains(datatableFilter.Search))

                             ).ToList();
                    }


                    //Sorting
                    if (!String.IsNullOrWhiteSpace(datatableFilter.SortColumn))
                    {
                        switch (datatableFilter.SortDirection)
                        {
                            case "asc":
                                {
                                    //var OrderedStudent = from s in Students orderby datatableFilter.SortColumn, s.FirstName select s; 
                                    var OrderedStudent = Sorting.OrderByField<Student>(Students.AsQueryable(), datatableFilter.SortColumn, true).ToList();
                                    Students = OrderedStudent;
                                    break;
                                }
                            case "desc":
                                {
                                    var OrderedStudent = Sorting.OrderByField<Student>(Students.AsQueryable(), datatableFilter.SortColumn, false).ToList();
                                    Students = OrderedStudent;
                                    break;
                                }
                            default:
                                {
                                    var OrderedStudent = from s in Students orderby s.FirstName ascending select s;
                                    Students = OrderedStudent.ToList();
                                    break;
                                }

                        }
                    }
                    else
                    {
                        var OrderedStudent = from s in Students orderby s.FirstName ascending select s;
                        Students = OrderedStudent.ToList();
                    }
                    //Students = (from s in Students orderby s.FirstName ascending select s).ToList();



                    //Paging
                    if (datatableFilter.RowSize > 0)
                    {
                        Students = Students.Skip(datatableFilter.Start).Take(datatableFilter.RowSize).ToList();
                    }

                    return Students;

                }
                else
                    return _context.Students.ToListAsync().Result;
            }
            catch (Exception exception)
            {
                throw;
            }
            return null;
        }

        public async Task<Student> FindByIdAsync(int id)
        {
            Student student = _context.Students.Find(id);
            student.Subjects = await _context.Subjects.Where(su => su.StudentId == id).ToListAsync();

            return student;

        }

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
        }

        public void Update(int id, Student student)
        {

            var existingStudent = _context.Students.Find(id);

            try
            {
                if (existingStudent.Id > 0)
                {
                    //Update Previous Exsiting

                    var listExistingSubjectToBeUpdated = student.Subjects.Where(su => su.Id > 0).ToList();

                    if (listExistingSubjectToBeUpdated != null && listExistingSubjectToBeUpdated.Count > 0)
                    {
                        listExistingSubjectToBeUpdated.ForEach(su => su.StudentId = id);
                        _context.Subjects.UpdateRange(listExistingSubjectToBeUpdated);
                    }

                    //deleteing the removed subjects
                    var listOfSubjectsToBeDeleted = _context.Subjects.Where(su => su.StudentId == id && !listExistingSubjectToBeUpdated.Exists(sp => sp.Id == su.Id)).ToList();

                    if (listOfSubjectsToBeDeleted != null && listOfSubjectsToBeDeleted.Count > 0)
                    {
                        _context.Subjects.RemoveRange(listOfSubjectsToBeDeleted);
                    }

                    //Add new subjects
                    var listOfSubjectsToBeAdded = student.Subjects.Where(su => su.Id == 0).ToList();

                    if (listOfSubjectsToBeAdded != null && listOfSubjectsToBeAdded.Count > 0)
                    {
                        listOfSubjectsToBeAdded.ForEach(su => su.Student = existingStudent);
                        _context.Subjects.AddRange(listOfSubjectsToBeAdded);
                    }

                    //Update Student Details
                    existingStudent.FirstName = student.FirstName;
                    existingStudent.LastName = student.LastName;
                    existingStudent.Class = student.Class;

                }

            }
            catch (Exception)
            {
                throw;
            }




            //_context.Students.Update(existingStudent);

            //if (existingStudent == null)
            //    return new ResponseStatus("Category not found.", false);

            //var listExistingSubject = existingStudent.Subjects;

            //listExistingSubject.ForEach(su =>
            //    {
            //        student.Subjects.ForEach(ps =>
            //        {
            //            if (ps.Id == su.Id)
            //            {
            //                su.SubjectName = ps.SubjectName;
            //                su.Marks = ps.Marks;
            //            }
            //        });

            //    });

            //existingStudent.Subjects = listExistingSubject;


            //existingStudent.FirstName = student.FirstName;
            //existingStudent.LastName = student.LastName;
            //existingStudent.Class = student.Class;
            //existingStudent.Subjects = student.Subjects;
            //_context.Students.Attach(student);


            // return new ResponseStatus("",false);
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
        }



    }


}