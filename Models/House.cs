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

    public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Levels { get; set; }
        public string Description { get; set; }

        public string Url { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}