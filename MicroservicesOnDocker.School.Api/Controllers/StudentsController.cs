using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.School.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly Database.IStore _store;
        public StudentsController(Database.IStore store)
        {
            _store = store;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dtos.StudentDto>>> Get()
        {
            var students = _store.GetStudents();
            var courses = _store.GetCourses();
            var payments = await Infrastructure.ServiceHelpers.GetServiceData<List<Dtos.StudentPaymentDto>>(
                Infrastructure.ServiceHelpers.IncomeService, "payments");
            return students.Select(x => new Dtos.StudentDto
            {
                StudentId = x.Id,
                StudentName = x.Name,
                CourseId = x.CourseId,
                CourseName = x.CourseId.HasValue ? courses.Single(y => y.Id == x.CourseId).Name : "",
                hasPaid = payments.Any(y => y.StudentId == x.Id && y.CourseId == x.CourseId)
            }).ToList();
        }
    }
}
