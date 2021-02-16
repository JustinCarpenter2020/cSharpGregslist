using cSharpGregslist.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using cSharpGregslist.db;

namespace cSharpGregslist.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HousesController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(FakeDB.Houses);
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<House> CreateHouse([FromBody] House newHouse)
        {
            try
            {
                FakeDB.Houses.Add(newHouse);
                return Ok(newHouse);
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{houseId}")]
        public ActionResult<House> FindHouseById(string houseId)
        {
            try
            {
                House foundHouse = FakeDB.Houses.Find(h => h.Id == houseId);
                return Ok(foundHouse);
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
        
    }
}