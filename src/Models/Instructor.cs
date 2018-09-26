using Dapper;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace Workforce.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Specialty { get; set; }

        [Required]
        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }

        [Display(Name = "Instructor Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
