using ScheduleDbManager.Domain.Entities;
using System.Collections.Generic;

namespace ScheduleDbManager.DAL
{
    internal interface IScheduleDataAccess
    {
        bool AddSchedule(Schedule schedule);
        List<Schedule> GetAllScheduleByPersonId(string personId);
    }
}