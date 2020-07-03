using System;
using System.Collections.Generic;
using AutoMapper;
using DuckTaleSolutionTask.Models;
using DuckTaleSolutionTask.Models.Entities;
using DuckTaleSolutionTask.Models.Interfaces;
using DuckTaleSolutionTask.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace DuckTaleSolutionTask.Controllers
{
    [Route("Student")]
    public class StudentController : Controller
    {
        ResponseStatus responseStatus;
        private readonly IStudentService _studentService;

        Mapper _mapper;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;


            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<List<Student>, List<StudentViewModel>>();

            });

            _mapper = new Mapper(config);


        }

      
        public IActionResult ViewStudent()
        {
            return View();
        }

      
    }

}