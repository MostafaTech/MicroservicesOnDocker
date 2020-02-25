using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.Income.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController
    {
        private readonly Database.DataStore _ds;
        public PaymentsController()
        {
            _ds = new Database.DataStore();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ViewModels.StudentPayment>> Get()
        {
            var payments = _ds.GetPayments();
            var courses = _ds.GetCourses();
            var students = _ds.GetStudents();
            return payments.Select(x => new ViewModels.StudentPayment
            {
                StudentName = students.Single(y => y.Id == x.StudentId).Name,
                CourseName = courses.Single(y => y.Id == x.CourseId).Name,
                PayAmount = x.PayAmount
            }).ToList();
        }

        [HttpGet("{studentId}/{courseId}")]
        public ActionResult<decimal> Get(long studentId, long courseId)
        {
            var payments = _ds.GetPayments();
            var requestedPayment = payments.FirstOrDefault(x => x.StudentId == studentId && x.CourseId == courseId);
            if (requestedPayment != null)
                return requestedPayment.PayAmount;
            return 0;
        }
    }
}
