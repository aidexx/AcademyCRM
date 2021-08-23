using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCRM.BLL.Models
{
    public class Teacher : Person
    {
        public int? YearsOfExperience { get; set; }
        public string? Bio { get; set; }
    }
}
