using CrmServices.Dtos;
using LightCrmData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmServices.Services
{
    public class TimeTableService : ITimeTableService
    {
        public IEnumerable<TimeTableDto> GetTimeByUser (TimeTableDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            using (var context = new CrmContext())
            {
                var timetablesresult = context.Timetables.Where(timetable => timetable.User.Id == user.Id).ToList();
                return timetablesresult.Select(x => new TimeTableDto());
            }
        }

        public void DoWork()
        {
            throw new System.NotImplementedException();
        }
    }
}
