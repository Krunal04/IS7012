namespace RecruitCatShigavkp.Models
{
    public class Jobtitle
    {
        public int jobtitleId { get; set; }  /*Primary Key*/

        public string? titleName { get; set; }

        public int minSalary { get; set; }

        public int maxSalary { get; set; }

        public DateTime? deadLine { get; set; }

        public string? skills { get; set; }

        public string? jobType { get; set; } /* Full Time or Part Time or Internship */ 


    }
}
