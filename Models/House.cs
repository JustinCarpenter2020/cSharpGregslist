using System;
using System.ComponentModel.DataAnnotations;

namespace cSharpGregslist.Models
{
    public class House
    {
    public House(int bedrooms, int bathrooms, int year, int price, int levels, string description, string url)
    {
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Year = year;
      Price = price;
      Levels = levels;
      Description = description;
      Url = url;
    }


[Required]    
public int Bedrooms { get; set; }
[Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Levels { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        public string Url { get; set; }
        [Required]

        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}