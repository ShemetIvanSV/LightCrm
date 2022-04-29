using CrmModels;
using CrmServices.Interfaces;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmServices.Services
{
    public class RolesService : IRolesService
    {
        public void AddNewRole(RoleDto roleDto)
        {
            try
            {
                using (var context = new CrmContext())
                {
                    context.Roles.Add(new Role
                    {
                        Id = roleDto.Id,
                        Name = roleDto.Name
                    });

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении роли", ex);
            }
        }

        public void DeleteRole(RoleDto roleDto)
        {
            try
            {
                using (var context = new CrmContext())
                {

                    Role role = context.Roles.FirstOrDefault(r => r.Id == roleDto.Id);
                    context.Roles.Remove(role);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении роли", ex);
            }
        }

        public RoleDto GetRoleById(int id)
        {
            try
            {
                using (var context = new CrmContext())
                {
                    var role = context.Roles.FirstOrDefault(r => r.Id == id);
                    var users = context.Users.Where(u => u.RoleId == id).ToList();

                    return new RoleDto
                    {
                        Id = role.Id,
                        Name = role.Name,
                        Users = users.Select(user => new UserDto()).ToList()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении данных роли", ex);
            }
        }

        public IEnumerable<RoleDto> GetRoles()
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении списка ролей", ex);
            }
        }

        public void UpdateRole(RoleDto roleDto)
        {
            try
            {
                //TODO
                using (var context = new CrmContext())
                {
                    

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при редактировании роли", ex);
            }
        }
    }
}
