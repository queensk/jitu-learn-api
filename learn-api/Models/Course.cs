using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace learn_api.Models
{
    public class Course: BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        [ForeignKey("instructorId")]
        public Instructor Instructor { get; set; }

        public Guid InstructorId { get; set; }

        public List<User> Users { get; set; }
    }
}