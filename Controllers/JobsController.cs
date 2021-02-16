using cSharpGregslist.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using cSharpGregslist.db;

namespace cSharpGregslist.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class JobsController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            try
            {
                return Ok(FakeDB.Jobs);
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                FakeDB.Jobs.Add(newJob);
                return Ok(newJob);
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
        [HttpGet("{jobId}")]
        public ActionResult<Job> FindJobById(string jobId)
        {
           try
           {
                Job returnJob = FakeDB.Jobs.Find(j => j.Id == jobId);
            return Ok(returnJob);
           }
           catch (System.Exception err)
           {
               
               return BadRequest(err.Message);
           }
        }
        [HttpDelete("{jobId}")]
        public ActionResult<string> DeleteJob(string jobId)
        {
            try
            {
                Job jobToRemove = FakeDB.Jobs.Find(j => j.Id == jobId);
                if(FakeDB.Jobs.Remove(jobToRemove))
                {
                    return Ok("Job has been deleted");

                };
                throw new System.Exception("This job does not exist");
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }




    }
}