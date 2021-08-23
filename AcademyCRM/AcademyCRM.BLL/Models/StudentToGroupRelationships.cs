using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCRM.BLL.Models
{
    public class StudentToGroupRelationships
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int GroupId { get; set; }
        public StudentGroup Group { get; set; }
    }
}
