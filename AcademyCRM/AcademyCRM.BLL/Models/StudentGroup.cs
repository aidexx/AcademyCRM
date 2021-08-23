using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace AcademyCRM.BLL.Models
{
    public enum GroupStatus
    {
        Pending,
        Started,
        OnPause,
        Finished,
        Cancelled
    }

    public enum GroupType{
        Online,
        Offline,
        Mixed
    }

    public class StudentGroup
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int? TeacherId { get; set; }

        public Teacher? Teacher { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }

        //public Location Location { get; set; }

        public DateTime? StartDate { get; set; }

        public GroupStatus Status { get; set; }

        public GroupType GroupType { get; set; }
    }

}
