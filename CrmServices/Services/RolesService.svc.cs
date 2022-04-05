using CrmServices.Dtos;
using CrmServices.Interfaces;
using LightCrmData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmServices.Services
{
    public class RolesService : IRolesService
    {
        public void AddNewRole(RoleDto role)
        {
            throw new NotImplementedException();
            
                /*using (var context = new CrmContext())
                {
                    context.Roles.Add(new Role
                    {
                        Id = role.Id,
                        Name = role.Name
                    });

                    context.SaveChanges();
                }*/
        }

        public void DeleteRole(RoleDto role)
        {
            throw new NotImplementedException();
        }

        public RoleDto GetRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleDto> GetRoles()
        {
            using (var context = new CrmContext())
            {
                var roles = context.Roles.Select(u => new RoleDto
                {
                    Id = u.Id,
                    Name = u.Name,                                   
                }).ToList();

                return (IEnumerable<RoleDto>)roles;
            }
        }

        public void UpdateRole(RoleDto role)
        {
            throw new NotImplementedException();
        }
    }
}
