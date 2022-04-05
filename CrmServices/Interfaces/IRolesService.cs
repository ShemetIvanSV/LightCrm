using CrmModels;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Interfaces
{
    [ServiceContract]
    public interface IRolesService
    {
        [OperationContract]
        void AddNewRole(RoleDto role);

        [OperationContract]
        void UpdateRole(RoleDto role);

        [OperationContract]
        void DeleteRole(RoleDto role);

        [OperationContract]
        IEnumerable<RoleDto> GetRoles();

        [OperationContract]
        RoleDto GetRoleById(int id);
    }
}