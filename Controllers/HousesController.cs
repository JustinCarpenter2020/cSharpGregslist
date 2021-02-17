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
                return Ok(_hs.FindHouseById(houseId));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{houseId}")]
        public ActionResult<House> EditHouse([FromBody] House newHouse, string houseId)
        {
            try
            {
                newHouse.Id = houseId;
                return(_hs.EditHouse(newHouse));
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
               _hs.DeleteHouse(houseId);
               return Ok("House successfully deleted");
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
        
    }
}