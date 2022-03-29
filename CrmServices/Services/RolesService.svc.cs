using CrmServices.Dtos;
using CrmServices.Interfaces;
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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "RolesService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы RolesService.svc или RolesService.svc.cs в обозревателе решений и начните отладку.
    public class RolesService : IRolesService
    {
        public void AddNewRole(RoleDto role)
        {
            using (var context = new CrmContext())
            {                
                context.Roles.Add(new Role
                {
                    Id = role.Id,
                    Name = role.Name
                });

                context.SaveChanges();
            }
        }

        public void DeleteRole(RoleDto role)
        {
            throw new NotImplementedException();
        }

        public RoleDto GetRoleById(string login, string password)
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
