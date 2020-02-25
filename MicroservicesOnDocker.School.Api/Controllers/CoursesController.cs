using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController
    {
        private readonly Database.DataStore _ds;
        public CoursesController()
        {
            _ds = new Database.DataStore();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Course>> Get()
        {
            return _ds.GetCourses();
        }
    }
}
