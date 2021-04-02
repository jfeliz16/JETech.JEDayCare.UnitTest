using JETech.NetCoreWeb;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JETech.JEDayCare.Core.Clients.Models;
using System.Linq;
using JETech.JEDayCare.Core.Data.Entities;
using JETech.NetCoreWeb.Types;
using JETechSic.Core.UnitTest;
using JETech.JEDayCare.Core.Clients.Interfaces;
using JETech.JEDayCare.Core.Administration.Interfaces;

namespace JETech.JEDayCare.Core.UnitTest.Client
{
    public class ClientService
    {
        private readonly JEDayCareDbContext _dbContext;
        private readonly IClientService _srvClient;
        private readonly IPersonService _srvPerson;

        public ClientService() {
            _dbContext = Utility.GetInMemorySicDbContext();
            _srvPerson = new JEDayCare.Core.Administration.Services.PersonService(_dbContext);
            _srvClient = new JETech.JEDayCare.Core.Clients.Services.ClientService(_dbContext, _srvPerson);
        }

        [Fact]
        public void GetClients() 
        {
            ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>();

            var result = _srvClient.GetClients(args);
          
            Assert.NotNull(result.Data);
            Assert.True(result.Data.Count() > 0);
        }

        [Fact]
        public void GetClients_Paging()
        {
            ActionQueryArgs<ClientModel> args = new ActionQueryArgs<ClientModel>(){};

            args.PageArgs = new PageArgs() { Num = 2, Size = 10 };            

            var result =  _srvClient.GetClients(args);

            Assert.NotNull(result.Data);
            Assert.Equal(10, result.Data.ToList().Count);
        }
    }
}
