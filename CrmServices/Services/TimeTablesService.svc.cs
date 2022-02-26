using CrmServices.Dtos;
using CrmServices.Interfaces;
using LightCrmData;
using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmServices
{
    public class TimeTablesService : ITimeTablesService
    {
        public IEnumerable<TimeTableDto> GetTimeByUser(UserDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            using (var context = new CrmContext())
            {
                var timetablesresult = context.Timetables.Where(timetable=>timetable.User.Id == user.Id).ToList();
                return timetablesresult.Select(x=> new TimeTableDto());
            }
        }
    }
}
