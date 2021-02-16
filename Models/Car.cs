using System;
using System.ComponentModel.DataAnnotations;

namespace cSharpGregslist.Models
{
    public class Car
    {
    public Car(string make, string model, int year, string description, string url)
    {
      Make = make;
      Model = model;
      Year = year;
      Description = description;
      Url = url;
    }

    public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}