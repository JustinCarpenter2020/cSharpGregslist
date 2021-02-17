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

          public string DeleteHouse(string houseId)
          {
              House houseToRemove = FakeDB.Houses.Find(h => h.Id == houseId);
              if(houseToRemove != null)
              {
                  FakeDB.Houses.Remove(houseToRemove);
                  return "Deleted";
              }
               throw new SystemException("This id is invalid");
          }




    }
}