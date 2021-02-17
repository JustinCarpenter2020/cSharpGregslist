using cSharpGregslist.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using cSharpGregslist.db;
using cSharpGregslist.Services;

namespace cSharpGregslist.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class JobsController: ControllerBase
    {
        private readonly JobsService _js;
        public JobsController(JobsService js)
        {
            _js = js;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            try
            {
                return Ok(_js.Get());
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
                return Ok(_js.Create(newJob));
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
            return Ok(_js.FindJobById(jobId));
           }
           catch (System.Exception err)
           {
               
               return BadRequest(err.Message);
           }
        }
        [HttpPut("{jobId}")]
        public ActionResult<Job> EditJob([FromBody] Job newJob, string jobId)
        {
            try
            {
                newJob.Id = jobId;
                return Ok(_js.EditJob(newJob));
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
            _js.DeleteJob(jobId);
            return Ok("Job successfully deleted");
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }




    }
}