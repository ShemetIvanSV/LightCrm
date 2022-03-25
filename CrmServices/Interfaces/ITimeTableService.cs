using CrmServices.Dtos;
using System.Collections.Generic;
using System.ServiceModel;

namespace CrmServices.Services
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ITimeTableService" в коде и файле конфигурации.
    [ServiceContract]
    public interface ITimeTableService
    {
        [OperationContract]
        IEnumerable<TimeTableDto> GetTimeByUser(UserDto user);
    }
}
