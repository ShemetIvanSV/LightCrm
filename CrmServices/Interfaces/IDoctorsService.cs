using CrmModels;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Services
{
    [ServiceContract]
    public interface IDoctorsService
    {
        [OperationContract]
        void SetDiagnosis(DoctorDto doctor);

        [OperationContract]
        void AppointTreatment(DoctorDto doctor);

        [OperationContract]
        void PrescribeMedications(DoctorDto doctor);

        [OperationContract]
        void RedirecToAnotherDoctor(DoctorDto doctor);

        [OperationContract]
        IEnumerable<DoctorDto> GetDoctors();
    }
}