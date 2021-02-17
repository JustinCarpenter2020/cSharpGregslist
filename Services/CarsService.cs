using System;
using System.Collections.Generic;
using cSharpGregslist.db;
using cSharpGregslist.Models;

namespace cSharpGregslist.Services
{
    public class CarsService
    {
        public IEnumerable<Car> Get()
        {
            return FakeDB.Cars;
        }




    }
}