using System.ComponentModel.DataAnnotations;

namespace RecruitCatShigavkp.Models
{
    public class Jobtitle
    {
        public int jobtitleId { get; set; }  /*Primary Key*/


        [System.ComponentModel.DisplayName("Job Title")]

        public string? titleName { get; set; }

        [System.ComponentModel.DisplayName("Minimum Salary")]
        public int minSalary { get; set; }
        [Range(500, 99999)]

        [System.ComponentModel.DisplayName("Maximum Salary")]
        public int maxSalary { get; set; }

        [DataType(DataType.Date)]
        [System.ComponentModel.DisplayName("Last Date To Apply")]
        public DateTime? deadLine { get; set; }

        [System.ComponentModel.DisplayName("Required Skills")]
        [Required(ErrorMessage = "Skills required")]
        public string? skills { get; set; }

        [System.ComponentModel.DisplayName("Job Type")]
        public string? jobType { get; set; } /* Full Time or Part Time or Internship */

        public List<Candidate>? Candidate { get; set; }


    }
}
