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
         public Car Create(Car createdCar)
         {
        FakeDB.Cars.Add(createdCar);
        return createdCar;
         }

         public string deleteCar(string carId)
         {
             Car car = FakeDB.Cars.Find(c => c.Id == carId);
             if(car != null)
             {
                 FakeDB.Cars.Remove(car);
                 return("Deleted");
             }
             throw new SystemException("This id is invalid");
         }





    }
}