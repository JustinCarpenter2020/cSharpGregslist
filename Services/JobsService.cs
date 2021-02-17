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






    }
}