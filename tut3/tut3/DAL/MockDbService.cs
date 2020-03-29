using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut3.Models;

namespace tut3.Services
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent=1, FirstName="Vova", LastName="Grady", IndexNumber="s1234"},
                new Student{IdStudent=2, FirstName="Anna", LastName="Folic", IndexNumber="s3446"},
                new Student{IdStudent=3, FirstName="Max", LastName="Smith", IndexNumber="s5644"}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
