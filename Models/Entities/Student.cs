
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DuckTaleSolutionTask.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "First Name cannot be greater than 30 characters.")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "Last Name cannot be greater than 30 characters.")]
        public string LastName { get; set; }

        [StringLength(30, ErrorMessage = "Class cannot be greater than 30 characters.")]
        public string Class { get; set; }


        public List<Subject> Subjects { get; set; }



    }
}