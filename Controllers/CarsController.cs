using cSharpGregslist.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using cSharpGregslist.db;
using cSharpGregslist.Services;
namespace cSharpGregslist.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CarsController: ControllerBase
    {
        private readonly CarsService _cs;
          public CarsController(CarsService cs)
    {
      _cs = cs;
    }
         [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
     try
     {
         return Ok(_cs.Get());
     }
     catch (System.Exception err)
     {
         
         return BadRequest(err.Message);
     }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
        try
        {
            Car createdCar = _cs.Create(newCar);
            return Ok(newCar);
        }
        catch (System.Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }

    [HttpDelete("{carId}")]
    public ActionResult<string> deleteCar(string carId)
    {
        try
        {
            Car carToDelete = FakeDB.Cars.Find(c => c.Id == carId);
            if(FakeDB.Cars.Remove(carToDelete))
            {
                return Ok("Car has been deleted");
            };
            throw new System.Exception("This Car doesn't exist");
        }
        catch (System.Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{carId}")]
    public ActionResult<Car> GetCarById(string carId)
    {
      try
      {
        Car carToReturn = FakeDB.Cars.Find(c => c.Id == carId);
        return Ok(carToReturn);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
[HttpPut("{carId}")]
public ActionResult<Car> editCar([FromBody] Car newCar)
{
    try
    {
        Car returnCar = FakeDB.Cars.Find(c => c.Id == newCar.Id);
        if(returnCar != null)
        {
        returnCar.Model = newCar.Model;
        returnCar.Make = newCar.Make;
        returnCar.Year = newCar.Year;
        returnCar.Description = newCar.Description;
        returnCar.Url = newCar.Url;
        return returnCar;

        } else
        {
            return NotFound();
        }
    }
    catch (System.Exception err)
    {
        
        return BadRequest(err.Message);
    }
}

    }
}
