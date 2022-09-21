using System.ComponentModel.DataAnnotations;

namespace RecruitCatShigavkp.Models
{
    public class Candidate
    {
        public int candidateId { get; set; }  /*Primary Key*/

        [System.ComponentModel.DisplayName("First Name")]
        [Required(ErrorMessage = "First Name required")]
        public string? candidateFname { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name required")]
        public string?candidateLname { get; set; }

        [System.ComponentModel.DisplayName("Expected Salary")]
        [Range(1000, 99999)]

        public int targetSalary { get; set; }

        [DataType(DataType.Date)]
        [System.ComponentModel.DisplayName("Expected Joining Date")]
        public DateTime? startDate { get; set; }

        [System.ComponentModel.DisplayName("Email ID")]
        public string? emailId { get; set; }

        [System.ComponentModel.DisplayName("Mobile Number")]
        public string? mobileNumber { get; set; }

        [System.ComponentModel.DisplayName(" Select Company Name")]
        public int? companyId { get; set; }
        public Company? Company { get; set; }

        [System.ComponentModel.DisplayName("Select Job Title")]
        public int? jobtitleId { get; set; }
        public Jobtitle? Jobtitle { get; set; }

        [System.ComponentModel.DisplayName(" Select Industry Name")]
        public int? industryId { get; set; }
        public Industry? Industry { get; set; }

            }
}
