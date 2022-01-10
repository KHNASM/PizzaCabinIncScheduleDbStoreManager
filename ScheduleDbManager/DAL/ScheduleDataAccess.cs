using ScheduleDbManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.DAL
{
    internal class ScheduleDataAccess : IScheduleDataAccess
    {

        public List<Schedule> GetAllScheduleByPersonId(string personId)
        {
            using ScheduleManagerContext context = new();
            return context.Schedules.Where(sc => sc.PersonId == personId).ToList();
        }


        public bool AddSchedule(Schedule schedule)
        {
            if (schedule != null)
            {
                using ScheduleManagerContext context = new();
                if (context.Schedules.Any(sc => sc.Date == schedule.Date && sc.PersonId == schedule.PersonId) == false) // Preventing a duplicate record entry
                {
                    context.Schedules.Add(schedule);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
