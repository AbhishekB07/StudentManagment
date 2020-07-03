using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DuckTaleSolutionTask.Models;
using DuckTaleSolutionTask.Models.Entities;
using DuckTaleSolutionTask.Models.Interfaces;
using DuckTaleSolutionTask.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DuckTaleSolutionTask.Controllers
{
    [Route("api")]
    public class StudentApiController : Controller
    {
        ResponseStatus responseStatus;
        private readonly IStudentService _studentService;

        Mapper _mapper;

        public StudentApiController(IStudentService studentService)
        {
            _studentService = studentService;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<List<Student>, List<StudentViewModel>>();
            });

            _mapper = new Mapper(config);
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        /// <summary>
        /// Here I am getting the list of Student for jquery datatable grid display.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("list")]
        public JsonResult GetStudentDetail()
        {
            var StudentData = new object();
            bool bStatus = false;
            int totlaRecord = 0;

            List<Student> lstStudent = new List<Student>();
            int nTotalRecord = 0;
            try
            {
                string[] TableField = {"", "ID", "FirstName", "LastName", "Class", "Subject", "Marks" };

                DatatableFilter datatable = new DatatableFilter();

                //Here I am getting the search query value form the datatable search input.
                datatable.Search = Request.Form["search[value]"].ToString();


                //here I am getting the start index and row size selected by the user from the datatable.
                datatable.Start = Convert.ToInt32(Request.Form["start"].ToString());

                datatable.RowSize = Convert.ToInt32(Request.Form["length"].ToString());

                //Here I am getting the sort column parameter, on which data will be sorted.
                datatable.SortColumn = TableField[Convert.ToInt32(Request.Form["order[0][column]"])];

                //Here I am getting the request parameter for sort type to be implemented
                datatable.SortDirection = Convert.ToString(Request.Form["order[0][dir]"]);

                lstStudent = _studentService.ListAsync(datatable).Result;

                totlaRecord = _studentService.TotlaRecords(datatable);

                if (lstStudent.Count > 0)
                    bStatus = true;

            }
            catch (Exception ex)
            {
                bStatus = false;
            }

            //Returning the object containing all the required data.
            StudentData = new { status = bStatus, data = lstStudent, recordsTotal = totlaRecord, recordsFiltered = totlaRecord };
            return Json(StudentData);
        }


        /// <summary>
        /// This Action is defined to Add new entry for student and it corresponding Subjects
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IActionResult AddStudent([FromBody]Student student)
        {
            var hdjj = Request.Body;
            ResponseStatus responseStatus = new ResponseStatus();
            try
            {

                if (ModelState.IsValid)
                    responseStatus = _studentService.SaveAsync(student).Result;
                else
                {
                    var errors = ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList().FirstOrDefault();

                    responseStatus.Message = errors[0].ErrorMessage;
                }

            }
            catch (Exception objException)
            {
                responseStatus = new ResponseStatus("", false);
            }

            var data = new { bStatus = responseStatus };
            return Json(data);
        }


        /// <summary>
        /// Here I have defined an action to update the student.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        public JsonResult Update([FromBody]Student student)
        {

            if (!ModelState.IsValid)
                return Json(new ResponseStatus("", false));

            int id = student.Id;
            var result = _studentService.UpdateAsync(id, student).Result;

            if (!result.Status)
                return Json(result.Message);

            return Json(result);
        }

        /// <summary>
        /// Here I am deleting student entry.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Route("Delete")]
        public JsonResult DeleteStudent(int id)
        {
            try
            {
                if (id > 0)
                    responseStatus = _studentService.DeleteAsync(id).Result;
            }
            catch (Exception)
            {
                responseStatus = new ResponseStatus();
            }

            return Json(responseStatus);
        }
    }
}
