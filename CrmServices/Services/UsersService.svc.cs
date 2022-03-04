using CrmServices.Dtos;
using CrmServices.Helpers;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CrmServices
{
    public class UsersService : IUsersService
    {
        public void AddNewUser(UserDto user)
        {
            using (var context = new CrmContext())
            {
                var department = context.Departments.Find(user.Department.Id);
                var role = context.Roles.Find(user.Role.Id);
                var timetables = context.Timetables.Where(x => user.Timetables.Select(y => y.Id).Contains(x.Id)).ToList();

                context.Users.Add(new User 
                { 
                    Name = user.Name,
                    Password = user.Password,
                    Patronymic = user.Patronymic,
                    Surname = user.Surname,
                    Username = user.Username,
                    Department = department,
                    Role = role,
                    Timetables = timetables
                });

                context.SaveChanges();
            }
        }

        public void DeleteUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers()
        {
            using (var context = new CrmContext())
            {
                var users = context.Users.Select(u => u).ToList();

                return (IEnumerable<UserDto>)users;
            }
        }

        public void UpdateUser(UserDto user)
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
