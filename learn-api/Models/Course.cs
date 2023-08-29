using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace learn_api.Models
{
    public class Course: BaseModel
    {
        public string Name { get; set; }=string.Empty;

        public string Description { get; set; }=string.Empty;

        public int Price { get; set; }

        public Instructor Instructor { get; set; }= new Instructor();
        [ForeignKey("InstructorId")]

        public List<User> Users { get; set; } = new List<User>();
    }
}