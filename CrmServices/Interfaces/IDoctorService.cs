using CrmServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrmServices.Services
{
    
    [ServiceContract]
    public interface IDoctorService
    {
     
        [OperationContract]
        void AddNewDoctorService(DoctorServiceDto service);

        [OperationContract]
        void UpdateDoctorService(DoctorServiceDto service);

        [OperationContract]
        void DeleteDoctorService(DoctorServiceDto service);

        [OperationContract]
        IEnumerable<DoctorServiceDto> GetService();
    }
}
