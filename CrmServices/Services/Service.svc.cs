using CrmServices.Dtos;
using LightCrmData;
using System;
using System.Collections.Generic;
using LightCrmData.Models;

namespace CrmServices.Services
{

    public class Service : IService
    {
        public void AddNewService(ServiceDto service)
        {
            using (var context = new CrmContext())
            {
                context.Services.Add(new LightCrmData.Models.Service
                {
                     Name = service.Name,
                     Price = service.Price,


                });
                context.SaveChanges();
            }
        }
        public void DeleteService(ServiceDto service)
        {
            using (var context = new CrmContext())
            {
                context.Services.Remove(new LightCrmData.Models.Service
                {
                    Name = service.Name,
                    Price = service.Price,


                });
                context.SaveChanges();
            }
        }

        public IEnumerable<ServiceDto> GetService()
        {
            throw new NotImplementedException();
        }

        public void UpdateService(ServiceDto service)
        {
            throw new NotImplementedException();
        }
    }
}
