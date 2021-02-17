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

         public House FindHouseById(string houseId)
         {
             House houseFound = FakeDB.Houses.Find(h => h.Id == houseId);
             if(houseFound != null)
             {
                 return houseFound;
             }
             throw new SystemException("This id is invalid");
         }




    }
}