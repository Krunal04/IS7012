using System.ComponentModel.DataAnnotations;

namespace RecruitCatShigavkp.Models
{
    public class Industry
    {
        public int industryId { get; set; } /*Primary Key*/

        [System.ComponentModel.DisplayName("Industry Name")]
        
        [Required(ErrorMessage = "Industry Name required")]
        public string? industryName { get; set; }

        [System.ComponentModel.DisplayName("Type Of Industry")]
        public string? industryType { get; set; }

        public List <Candidate>? Candidate { get; set; }

        public List <Company>? Company { get; set; }

        

        


    }
}
