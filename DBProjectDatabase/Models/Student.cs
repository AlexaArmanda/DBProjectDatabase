using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DBProjectDatabase.Models
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        [ForeignKey("RoleId")]
        public Role? Role { get; set; }

        [ForeignKey("YearOfStudyId")]
        public YearOfStudy? YearOfStudy { get; set; }

        [ForeignKey("SpecializationId")]
        public Specialization? Specialization { get; set; }

        [ForeignKey("GroupNoId")]
        public GroupNo? GroupNo { get; set; }

        [ForeignKey("SubgroupId")]
        public Subgroup? Subgroup { get; set; }

        [ForeignKey("DegreeId")]
        public Degree? Degree { get; set; }

        public string AnnonymizationCode { get; set; } = string.Empty;
        public bool IsScholar { get; set; }
        public bool IsPayingStudies { get; set; }
        public ICollection<Grade>? Grades { get; set; }

    }
}
