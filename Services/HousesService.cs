using System;
using System.Collections.Generic;
using cSharpGregslist.db;
using cSharpGregslist.Models;

namespace cSharpGregslist.Services
{
    public class HousesService
    {
         public IEnumerable<House> Get()
         {
             return FakeDB.Houses;
         }
    }
}