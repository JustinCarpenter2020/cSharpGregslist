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

    [HttpGet("{carId}")]
    public ActionResult<Car> GetCarById(string carId)
    {
      try
      {
          //REVIEW why do it this way rather then what is in my house controller
        Car foundCar = _cs.GetCarById(carId);
        return Ok(foundCar);
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
            return Ok(_cs.Create(newCar));
        }
        catch (System.Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }

[HttpPut("{carId}")]
public ActionResult<Car> editCar([FromBody] Car newCar, string carId)
{
    try
    {
        newCar.Id = carId;
       Car updatedCar = _cs.editCar(newCar);
       return Ok(updatedCar);
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
            _cs.deleteCar(carId);
            return Ok("Deleted");
        }
        catch (System.Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }


    }
}
