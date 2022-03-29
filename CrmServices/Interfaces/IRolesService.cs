using CrmServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace CrmServices.Interfaces
{
    public interface IRolesService
    {
        [OperationContract]
        void AddNewRole(RoleDto user);

        [OperationContract]
        void UpdateRole(UserDto user);

        [OperationContract]
        void DeleteRole(UserDto user);

        [OperationContract]
        IEnumerable<RoleDto> GetRoles();

        [OperationContract]
        RoleDto GetRoleById(string login, string password);
    }
}