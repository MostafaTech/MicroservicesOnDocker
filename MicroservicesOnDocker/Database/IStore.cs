using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Database
{
    public interface IStore
    {
        List<Models.Course> GetCourses();
        List<Models.Student> GetStudents();
        List<Models.Payment> GetPayments();

        void AddCourse(Models.Course course);
        void AddStudent(Models.Student student);
        void AddPayment(Models.Payment payment);
    }
}
