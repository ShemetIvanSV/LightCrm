using CrmModels;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Interfaces
{
    [ServiceContract]
    public interface IRolesService
    {
        [OperationContract]
        void AddNewRole(RoleDto roleDto);

        [OperationContract]
        void UpdateRole(RoleDto roleDto);

        [OperationContract]
        void DeleteRole(RoleDto roleDto);

        [OperationContract]
        IEnumerable<RoleDto> GetRoles();

        [OperationContract]
        RoleDto GetRoleById(int id);
    }
}