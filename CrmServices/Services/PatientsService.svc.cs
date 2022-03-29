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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "PatientsService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы PatientsService.svc или PatientsService.svc.cs в обозревателе решений и начните отладку.
    public class PatientsService : IPatientsService
    {
        public void AddNewPatient(PatientDto patient)
        {
            using (var context = new CrmContext())
            {
                context.Patients.Add(new Patient
                {
                    Name = patient.Name,
                    Sername = patient.Sername,
                    Patronymic = patient.Patronymic,
                    Birthday = patient.Birthday,
                    Gender = patient.Gender,
                    Phone = patient.Phone,
                    Email = patient.Email,
                    Allergies = patient.Allergies,
                });
                context.SaveChanges();

            }
        }

        public void DeletePatient(PatientDto patient)
        {
            using (var context = new CrmContext())
            {
                context.Patients.Remove(new Patient
                {
                    Name = patient.Name,
                    Sername = patient.Sername,
                    Patronymic = patient.Patronymic,
                    Birthday = patient.Birthday,
                    Gender = patient.Gender,
                    Phone = patient.Phone,
                    Email = patient.Email,
                    Allergies = patient.Allergies,
                });
                context.SaveChanges();
            }
        }
        public void UpdatePatient(PatientDto patient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientDto> GetPatients()
        {
            throw new NotImplementedException();
        }
    }
}
