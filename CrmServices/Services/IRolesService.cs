using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrmServices.Services
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IRolesService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IRolesService
    {
        [OperationContract]
        void DoWork();
    }
}
