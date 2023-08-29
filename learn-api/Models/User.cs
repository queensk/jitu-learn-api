using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_api.Models
{
    public class User : Person
    {
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}