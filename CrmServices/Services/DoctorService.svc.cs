using CrmServices.Dtos;
using LightCrmData;
using System;
using System.Collections.Generic;
using LightCrmData.Models;

namespace CrmServices.Services
{

    public class Service : IDoctorService
    {
        public void AddNewDoctorService(DoctorServiceDto service)
        {
            using (var context = new CrmContext())
            {
                context.Services.Add(new LightCrmData.Models.DoctorService
                {
                     Name = service.Name,
                     Price = service.Price,


                });
                context.SaveChanges();
            }
        }
        public void DeleteDoctorService(DoctorServiceDto service)
        {
            using (var context = new CrmContext())
            {
                context.Services.Remove(new LightCrmData.Models.DoctorService
                {
                    Name = service.Name,
                    Price = service.Price,


                });
                context.SaveChanges();
            }
        }

        public IEnumerable<DoctorServiceDto> GetService()
        {
            throw new NotImplementedException();
        }

        public void UpdateDoctorService(DoctorServiceDto service)
        {
            throw new NotImplementedException();
        }
    }
}
