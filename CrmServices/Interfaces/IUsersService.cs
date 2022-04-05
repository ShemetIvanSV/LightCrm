using CrmModels;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Interfaces
{

    [ServiceContract]
    public interface IUsersService
    {
        [OperationContract]
        void AddNewUser(UserDto user);

        [OperationContract]
        void UpdateUser(UserDto user);

        [OperationContract]
        void DeleteUser(UserDto user);

        [OperationContract]
        IEnumerable<UserDto> GetUsers();

        [OperationContract]
        UserDto GetUserByLoginData(string login, string password);
    }
}
