using CrmServices.Dtos;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrmServices.Services
{
    public class DoctorsService : IDoctorsService
    {
        public void SetDiagnosis(DoctorDto doctor)
        {
            throw new NotImplementedException();
        }

        public void AppointTreatment(DoctorDto doctor)
        {
            throw new NotImplementedException();
        }

        public void PrescribeMedications(DoctorDto doctor)
        {
            throw new NotImplementedException();
        }

        public void RedirecToAnotherDoctor(DoctorDto doctor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DoctorDto> GetDoctors()
        {
            throw new NotImplementedException();
        }
    }
}
