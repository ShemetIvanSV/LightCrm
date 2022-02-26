using CrmServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CrmServices.Interfaces
{
    [ServiceContract]
    public interface ITimeTablesService 
    {
        [OperationContract]
        IEnumerable<TimeTableDto> GetTimeByUser(UserDto user);
    }
}
