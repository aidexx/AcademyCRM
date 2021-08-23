using System;
using System.ComponentModel.DataAnnotations;

namespace AcademyCRM.BLL.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public abstract class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public Gender? Gender { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string? Phone { get; set; }

        public string? Address { get; set; }

        public DateTime DateCreated { get; set; }
    }


}
