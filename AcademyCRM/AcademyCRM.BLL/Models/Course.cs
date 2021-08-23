using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCRM.BLL.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public int? Duration { get; set; }

        public string? Description { get; set; }
        public int? StudentsCapacity { get; set; }

        public decimal Price { get; set; }

    }
}
