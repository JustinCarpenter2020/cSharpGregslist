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

         public House CreateHouse(House newHouse)
         {
             FakeDB.Houses.Add(newHouse);
                return newHouse;
         }




    }
}