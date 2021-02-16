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

    public string Company { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public int Rate { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}