using CrmServices.Dtos;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;

namespace CrmServices
{
    public class UsersService : IUsersService
    {
        public void AddNewUser(UserDto user)
        {
            using (var context = new CrmContext())
            {
                context.Users.Add(new User 
                { 
                    Name = user.Name,
                    Surname = user.Surname,
                    Patronymic = user.Patronymic,

                    Password = user.Password,

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
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
