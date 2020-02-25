using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController
    {
        private readonly Database.DataStore _ds;
        public StudentsController()
        {
            _ds = new Database.DataStore();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ViewModels.StudentBrief>> Get()
        {
            var students = _ds.GetStudents();
            var courses = _ds.GetCourses();
            var payments = _ds.GetPayments();
            return students.Select(x => new ViewModels.StudentBrief
            {
                StudentName = x.Name,
                CourseName = courses.Single(y => y.Id == x.CourseId).Name,
                HasPayed = payments.Any(y => y.StudentId == x.Id && y.CourseId == x.CourseId)
            }).ToList();
        }
    }
}
