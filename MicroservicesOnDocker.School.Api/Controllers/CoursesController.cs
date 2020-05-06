using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesOnDocker.School.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly Database.IStore _store;
        public CoursesController(Database.IStore store)
        {
            _store = store;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Course>> Get()
        {
            return _store.GetCourses();
        }
    }
}
