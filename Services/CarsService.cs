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
         public Car GetCarById(string carId)
         {
             Car foundCar = FakeDB.Cars.Find(c => c.Id == carId);
             if(foundCar != null)
             {
                 return foundCar;
             }
              throw new SystemException("This id is invalid");
         }
         public Car Create(Car createdCar)
         {
        FakeDB.Cars.Add(createdCar);
        return createdCar;
         }

         public Car editCar(Car updatedCar)
         {
              Car returnCar = FakeDB.Cars.Find(c => c.Id == updatedCar.Id);
        if(returnCar != null)
        {
        returnCar.Model = updatedCar.Model;
        returnCar.Make = updatedCar.Make;
        returnCar.Year = updatedCar.Year;
        returnCar.Description = updatedCar.Description;
        returnCar.Url = updatedCar.Url;
        return returnCar;
        }
        throw new SystemException("This car does not exist");
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