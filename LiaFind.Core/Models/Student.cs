using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiaFind.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentEmail { get; set; }
        public float StudentAge { get; set; }
    }
}
