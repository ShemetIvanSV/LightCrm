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
    public interface IService
    {
     
        [OperationContract]
        void AddNewService(ServiceDto service);

        [OperationContract]
        void UpdateService(ServiceDto service);

        [OperationContract]
        void DeleteService(ServiceDto service);

        [OperationContract]
        IEnumerable<ServiceDto> GetService();
    }
}
