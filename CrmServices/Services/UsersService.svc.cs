using CrmModels;
using CrmServices.Helpers;
using CrmServices.Interfaces;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CrmServices.Services
{
    public class UsersService : IUsersService
    {
        public void AddNewUser(UserDto userDto)
        {
            using (var context = new CrmContext())
            {
                var department = context.Departments.Find(userDto.Department.Id);
                var role = context.Roles.Find(userDto.Role.Id);
                //var timetables = context.Timetables.Where(x => userDto.Timetables.Select(y => y.Id).Contains(x.Id)).ToList();

                context.Users.Add(new User 
                { 
                    Name = userDto.Name,
                    Password = userDto.Password,
                    Patronymic = userDto.Patronymic,
                    Surname = userDto.Surname,
                    Username = userDto.Username,
                    Department = department,
                    Role = role,
                    //Timetables = timetables
                });

                context.SaveChanges();
            }
        }

        public void DeleteUser(UserDto userDto)
        {
            using (var context = new CrmContext())
            {

                User user = context.Users.FirstOrDefault(u => u.Id == userDto.Id);
                context.Users.Remove(user);

                context.SaveChanges();
            }
        }

        public IEnumerable<UserDto> GetUsers()
        {
            using (var context = new CrmContext())
            {
                var users = context.Users.Select(u => new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Surname = u.Surname,
                    Patronymic = u.Patronymic,
                    Username = u.Username,
                    Password = u.Password,
                    Role = new RoleDto { Id = u.RoleId, Name = u.Role.Name }, 
                    Department = new DepartmentDto { Id = u.DepartmentId, Name = u.Department.Name}, 
                    //Timetables = u.Timetables                     
                }).ToList();

                return (IEnumerable<UserDto>)users;
            }
        }

        public void UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserByLoginData(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
                throw new FaultException("Отсутствует логин пользователя!");
            if (string.IsNullOrEmpty(password))
                throw new FaultException("Отсутствует пароль пользователя!");

            using (var context = new CrmContext())
            {
                var findedUser = context.Users.FirstOrDefault(user =>user.Username == login);

                if (findedUser == null)
                    throw new FaultException("Такого пользователя не существует!");

                if (findedUser.Password != Cripto.Sha256(password))
                {
                    throw new FaultException("Не верный пароль!");
                }

                return new UserDto
                {
                    Id = findedUser.Id,
                    Name = findedUser.Name,
                    Surname = findedUser.Surname,
                    Password = findedUser.Password,
                    Patronymic = findedUser.Patronymic,
                    Username = findedUser.Username
                };
            }
        }
    }
}
