using CrmModels;
using CrmServices.Interfaces;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmServices.Services
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "DepartmentsService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы DepartmentsService.svc или DepartmentsService.svc.cs в обозревателе решений и начните отладку.
    public class DepartmentsService : IDepartmentsService
    {
        public void AddNewDepartment(DepartmentDto departmentDto)
        {
            try
            {
                using (var context = new CrmContext())
                {
                    context.Departments.Add(new Department
                    {
                        Id = departmentDto.Id,
                        Name = departmentDto.Name
                    });

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении рабочего места", ex);
            }
        }

        public void DeleteDepartment(DepartmentDto departmentDto)
        {
            try
            {
                using (var context = new CrmContext())
                {
                    Department department = context.Departments.FirstOrDefault(r => r.Id == departmentDto.Id);
                    context.Departments.Remove(department);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении рабочего места", ex);
            }
        }

        public IEnumerable<DepartmentDto> GetDepartments()
        {
            try
            {
                using (var context = new CrmContext())
                {
                    var departments = context.Departments.Select(u => new DepartmentDto
                    {
                        Id = u.Id,
                        Name = u.Name,
                    }).ToList();

                    return (IEnumerable<DepartmentDto>)departments;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении списка рабочих мест", ex);
            }
        }

        public DepartmentDto GetDepartmentById(int id)
        {
            try
            {
                using (var context = new CrmContext())
                {
                    var role = context.Departments.FirstOrDefault(r => r.Id == id);
                    var users = context.Users.Where(u => u.DepartmentId == id).ToList();

                    return new DepartmentDto
                    {
                        Id = role.Id,
                        Name = role.Name,
                        Users = users.Select(user => new UserDto()).ToList()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении данных рабочего места", ex);
            }
        }

        public void UpdateDepartment(DepartmentDto departmentDto)
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
                throw new Exception("Ошибка при редактировании рабочего места", ex);
            }
        }
    }
}
