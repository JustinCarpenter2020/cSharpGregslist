using System.Collections.Generic;
using cSharpGregslist.Models;
namespace cSharpGregslist.db
{
    public class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
        public static List<Job> Jobs { get; set; } = new List<Job>();
    }
}