using CrmServices.Dtos;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Services
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IPatientsService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IPatientsService
    {
        [OperationContract]
        void AddNewPatient(PatientDto patient);

        [OperationContract]
        void DeletePatient(PatientDto patient);

        [OperationContract]
        void UpdatePatient(PatientDto patient);

        [OperationContract]
        IEnumerable<PatientDto> GetPatients();

    }
}
