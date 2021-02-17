using System;
using System.ComponentModel.DataAnnotations;

namespace cSharpGregslist.Models
{
    public class Car
    {
    public Car(string make, string model, int year, string description, string url, int price)
    {
      Make = make;
      Model = model;
      Year = year;
      Description = description;
      Url = url;
      Price = price;
    }

[Required]
    public string Make { get; set; }
    [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]

        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}