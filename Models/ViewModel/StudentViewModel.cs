using DuckTaleSolutionTask.Models.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


namespace DuckTaleSolutionTask.Models.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }


        [StringLength(30)]
        public string Class { get; set; }

        public List<Subject> Subjects { get; set; }

        //public ICollection<Subject> Subjects { get; set; } = new Collection<Subject>();
    }

    public class Subject
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string SubjectName { get; protected set; }

        [StringLength(30)]
        public string Marks { get; protected set; }



    }

}
