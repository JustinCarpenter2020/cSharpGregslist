using cSharpGregslist.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using cSharpGregslist.db;
using cSharpGregslist.Services;

namespace cSharpGregslist.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HousesController: ControllerBase
    {
        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(_hs.Get());
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
                return Ok(_hs.CreateHouse(newHouse));
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

        [HttpDelete("{houseId}")]
        public ActionResult<string> DeleteHouse(string houseId)
        {
            try
            {
                House houseToRemove = FakeDB.Houses.Find(h => h.Id == houseId);
                if(FakeDB.Houses.Remove(houseToRemove))
                {
                    return Ok("Successfully deleted house");
                }
                throw new System.Exception("This house does not exist");
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
        
    }
}