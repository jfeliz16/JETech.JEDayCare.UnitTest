using JETech.JEDayCare.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JETechSic.Core.UnitTest
{
    public class Utility
    {
        public static SicDbContext GetInMemorySicDbContext()
        {
            var options = new DbContextOptionsBuilder<SicDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

            var context = new SicDbContext(options);

            var dataMockup = new DataMockup(context);

            context.Statues.AddRange(dataMockup.GetStatues());   
            context.Persons.AddRange(dataMockup.GetPersons());
            context.Clients.AddRange(dataMockup.GetClients());
            
            context.SaveChanges();
            return context;
        }
    }
}
