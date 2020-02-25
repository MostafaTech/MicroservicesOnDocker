using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Database
{
    public class DataStore
    {
        public List<Models.Course> GetCourses()
        {
            return new List<Models.Course>()
            {
                new Models.Course { Id = 1, Name = "Acting Course" },
                new Models.Course { Id = 2, Name = "Music Course" },
            };
        }

        public List<Models.Student> GetStudents()
        {
            return new List<Models.Student>()
            {
                new Models.Student { Id = 1, CourseId = 1, Name = "Johnny Depp" },
                new Models.Student { Id = 2, CourseId = 1, Name = "Brad Pitt" },
                new Models.Student { Id = 3, CourseId = 1, Name = "Leonardo DiCaprio" },

                new Models.Student { Id = 4, CourseId = 2, Name = "Michael Jackson" },
                new Models.Student { Id = 5, CourseId = 2, Name = "Freddy Mercury" },
            };
        }

        public List<Models.Payment> GetPayments()
        {
            return new List<Models.Payment>()
            {
                new Models.Payment { Id = 1, StudentId = 1, CourseId = 1, PayAmount = 2000m },
                new Models.Payment { Id = 2, StudentId = 2, CourseId = 1, PayAmount = 2000m },
                //new Models.Payment { Id = 3, StudentId = 3, CourseId = 1, PayAmount = 2000m },

                new Models.Payment { Id = 4, StudentId = 4, CourseId = 2, PayAmount = 3000m },
                //new Models.Payment { Id = 5, StudentId = 5, CourseId = 2, PayAmount = 3000m },
            };
        }
    }
}
