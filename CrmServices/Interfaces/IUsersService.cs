using CrmModels;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Interfaces
{

    [ServiceContract]
    public interface IUsersService
    {
        [OperationContract]
        void AddNewUser(UserDto userDto);

        [OperationContract]
        void UpdateUser(UserDto userDto);

        [OperationContract]
        void DeleteUser(UserDto userDto);

        [OperationContract]
        IEnumerable<UserDto> GetUsers();

        [OperationContract]
        UserDto GetUserByLoginData(string login, string password);
    }
}
