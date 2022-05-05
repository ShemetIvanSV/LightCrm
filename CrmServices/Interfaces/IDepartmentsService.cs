using CrmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace CrmServices.Interfaces
{
    [ServiceContract]
    public interface IDepartmentsService
    {
        [OperationContract]
        void AddNewDepartment(DepartmentDto departmentDto);

        [OperationContract]
        void UpdateDepartment(DepartmentDto departmentDto);

        [OperationContract]
        void DeleteDepartment(DepartmentDto departmentDto);

        [OperationContract]
        IEnumerable<DepartmentDto> GetDepartments();

        [OperationContract]
        DepartmentDto GetDepartmentById(int id);
    }
}