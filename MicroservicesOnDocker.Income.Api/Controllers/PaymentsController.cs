using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.Income.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly Database.IStore _store;
        public PaymentsController(Database.IStore store)
        {
            _store = store;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Dtos.StudentPaymentDto>> Get()
        {
            var payments = _store.GetPayments();
            var courses = _store.GetCourses();
            var students = _store.GetStudents();
            return payments.Select(x => new Dtos.StudentPaymentDto
            {
                StudentId = x.StudentId,
                StudentName = students.Single(y => y.Id == x.StudentId).Name,
                CourseId = x.CourseId,
                CourseName = courses.Single(y => y.Id == x.CourseId).Name,
                PayAmount = x.PayAmount
            }).ToList();
        }

        [HttpGet("{studentId}/{courseId}")]
        public ActionResult<decimal> Get(long studentId, long courseId)
        {
            var payments = _store.GetPayments();
            var requestedPayment = payments.FirstOrDefault(x => x.StudentId == studentId && x.CourseId == courseId);
            if (requestedPayment != null)
                return requestedPayment.PayAmount;
            return 0;
        }
    }
}
