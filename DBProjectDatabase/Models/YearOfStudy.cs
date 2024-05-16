using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class YearOfStudy
    {
        [Key]
        public Guid YearOfStudyId { get; set; }
        public int Number { get; set; }
    }
}