using System;
using System.ComponentModel.DataAnnotations;
namespace cSharpGregslist.Models
{
    public class Job
    {
    public Job(string company, string jobTitle, string description, int hours, int rate)
    {
      Company = company;
      JobTitle = jobTitle;
      Description = description;
      Hours = hours;
      Rate = rate;
    }

[Required]  
    public string Company { get; set; }
    [Required]  
        public string JobTitle { get; set; }
        [Required]  
        public string Description { get; set; }
        [Required]  
        public int Hours { get; set; }
        [Required]  
        public int Rate { get; set; }
        [Required]  
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}