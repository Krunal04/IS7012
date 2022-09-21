using System.ComponentModel.DataAnnotations;

namespace RecruitCatShigavkp.Models
{
    public class Company
    {
        public int companyId { get; set; }  /*Primary Key*/

        [System.ComponentModel.DisplayName("Company Name")]
        [Required(ErrorMessage = "Company Name required")]
        public string? companyName { get; set; }

        [System.ComponentModel.DisplayName("Position")]
        public string? position { get; set; }

        [System.ComponentModel.DisplayName("Minimum Salary")]
        public int min_salary { get; set; }

        [System.ComponentModel.DisplayName("Maximum Salary")]
        public int max_salary { get; set; }

        [DataType(DataType.Date)]
        [System.ComponentModel.DisplayName("Expected Joining Date")]
        public DateTime? start_date  { get; set; }

        [System.ComponentModel.DisplayName("Job Location")]
        public string? location { get; set; }

        [System.ComponentModel.DisplayName("Company Rank")]
        public int companyRank { get; set; }

        public List<Candidate>? Candidates { get; set; }

        [System.ComponentModel.DisplayName("Industry Name")]
        public int? industryId { get; set; }
        public Industry? Industry { get; set; }

     




    }


    
}
