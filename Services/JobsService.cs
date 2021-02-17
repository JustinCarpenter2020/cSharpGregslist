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

          public Job EditJob(Job newJob)
          {
              Job jobToReturn = FakeDB.Jobs.Find(j => j.Id == newJob.Id);
              if(jobToReturn != null)
              {
                  jobToReturn.Hours = newJob.Hours;
                  jobToReturn.Description = newJob.Description;
                  jobToReturn.Rate = newJob.Rate;
                  jobToReturn.Company = newJob.Company;
                  jobToReturn.JobTitle = newJob.JobTitle;
                  return jobToReturn;

              }
               throw new SystemException("This id is invalid");
          }

            public string DeleteJob(string jobId)
            {
                Job jobToRemove = FakeDB.Jobs.Find(j => j.Id == jobId);
                if(jobToRemove != null)
               {
                   FakeDB.Jobs.Remove(jobToRemove);
                   return "Job Removed";

               }
               throw new SystemException("This id is invalid");

            }






    }
}