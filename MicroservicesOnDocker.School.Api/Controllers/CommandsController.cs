using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.School.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CommandsController : Controller
    {
        private readonly Database.IStore _store;
        public CommandsController(Database.IStore store)
        {
            _store = store;
        }

        [HttpPost]
        public ActionResult AddSampleData()
        {
            // get sample data from hard-coded
            var sampleDataStore = new Database.DataStore();
            // add all courses
            foreach (var i in sampleDataStore.GetCourses())
                _store.AddCourse(i);
            // add all students
            foreach (var i in sampleDataStore.GetStudents())
                _store.AddStudent(i);
            // add all payments
            foreach (var i in sampleDataStore.GetPayments())
                _store.AddPayment(i);

            return Ok();
        }
    }
}
