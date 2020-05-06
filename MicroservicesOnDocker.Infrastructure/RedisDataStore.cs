using System;
using System.Collections.Generic;
using MicroservicesOnDocker.Models;
using StackExchange.Redis;

namespace MicroservicesOnDocker.Infrastructure
{
    public class RedisDataStore : Database.IStore
    {
        private const string Key_Courses = "MicroservicesOnDocker_Courses";
        private const string Key_Students = "MicroservicesOnDocker_Students";
        private const string Key_Payments = "MicroservicesOnDocker_Payments";
        private readonly ConnectionMultiplexer _connection;
        private readonly IDatabase _db;
        public RedisDataStore()
        {
            _connection = ConnectionMultiplexer.Connect("192.168.99.101");
            _db = _connection.GetDatabase();
        }


        public void AddCourse(Course course)
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(course);
            _db.SetAdd(Key_Courses, str);
        }

        public void AddStudent(Student student)
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(student);
            _db.SetAdd(Key_Students, str);
        }

        public void AddPayment(Payment payment)
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(payment);
            _db.SetAdd(Key_Payments, str);
        }

        public List<Course> GetCourses()
        {
            var data = new List<Course>();
            foreach(var i in _db.SetMembers(Key_Courses))
            {
                var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Course>(i.ToString());
                data.Add(obj);
            }
            return data;
        }

        public List<Student> GetStudents()
        {
            var data = new List<Student>();
            foreach (var i in _db.SetMembers(Key_Students))
            {
                var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(i.ToString());
                data.Add(obj);
            }
            return data;
        }

        public List<Payment> GetPayments()
        {
            var data = new List<Payment>();
            foreach (var i in _db.SetMembers(Key_Payments))
            {
                var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Payment>(i.ToString());
                data.Add(obj);
            }
            return data;
        }
    }
}
