using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut3.Models;

namespace tut3.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
