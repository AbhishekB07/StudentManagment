using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace DuckTaleSolutionTask.Models.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Marks { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
