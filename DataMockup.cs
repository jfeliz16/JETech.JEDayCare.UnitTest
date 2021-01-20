using JETech.JEDayCare.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JETechSic.Core.UnitTest
{
    public class DataMockup
    {
        private readonly SicDbContext _sicDb;

        public DataMockup(SicDbContext sicDb) 
        {
            _sicDb = sicDb;
        }

        public Person[] GetPersons() 
        {
            var status = _sicDb.Statues.Find(1);            

            return new[] {
                new Person
                {
                     FullName = "Andrick Lora ",
                     FirstName = "Andrick",
                     LastName = "Lora",
                     Address = "Juan de morfa",
                     Status = status
                },
                new Person
                {
                     FullName = "Andrick 2 Lora 2",
                     FirstName = "Andrick 2",
                     LastName = "Lora 2",
                     Address = "Juan de morfa",
                     Status = status
                },
                new Person
                {
                     FullName = "Andrick 3 Lora 3",
                     FirstName = "Andrick 3",
                     LastName = "Lora 3",
                     Address = "Juan de morfa",
                     Status = status
                },
                new Person
                {
                     FullName = "Andrick 4 Lora 4",
                     FirstName = "Andrick 4",
                     LastName = "Lora 4",
                     Address = "Juan de morfa",
                     Status = status
                },
            };
        }

        public Status[] GetStatues() => new[]
        {
            new Status
            {
                Id= 1,
                Name = "ACTIVO"
            },
            new Status
            {
                Id= 2,
                Name = "INACTIVO"
            },
        };

        public Client[] GetClients() 
        {
            var status = _sicDb.Statues.Find(1);            

            return new[] {
                new Client
                    {
                        Person = new Person
                        {
                            FullName = "Andrick Lora ",
                            FirstName = "Andrick",
                            LastName = "Lora",
                            Address = "Juan de morfa",
                            Status = status
                        }
                    },
                new Client
                {
                    Person = new Person
                    {
                        FullName = "Andrick Lora ",
                        FirstName = "Andrick",
                        LastName = "Lora",
                        Address = "Juan de morfa",
                        Status =status
                    }
                },
                new Client
                {
                    Person = new Person
                    {
                        FullName = "Andrick Lora ",
                        FirstName = "Andrick",
                        LastName = "Lora",
                        Address = "Juan de morfa",
                        Status = status
                    }
                },
                new Client
                {
                    Person = new Person
                    {
                        FullName = "Andrick Lora ",
                        FirstName = "Andrick",
                        LastName = "Lora",
                        Address = "Juan de morfa",
                        Status =status
                    }
                }
            };
        }
         
    }
}
