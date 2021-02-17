using System;
using System.Collections.Generic;
using cSharpGregslist.db;
using cSharpGregslist.Models;
namespace cSharpGregslist.Services
{
    public class JobsService
    {
         public IEnumerable<Job> Get()
         {
             return FakeDB.Jobs;
         }

         public Job Create(Job newJob)
         {
             FakeDB.Jobs.Add(newJob);
             return newJob;
         }

         public Job FindJobById(string jobId)
         {
             Job jobToReturn = FakeDB.Jobs.Find(j => j.Id == jobId);
             if(jobToReturn != null)
             {
                 return jobToReturn;
             }
             throw new SystemException("This id is invalid");
         }






    }
}