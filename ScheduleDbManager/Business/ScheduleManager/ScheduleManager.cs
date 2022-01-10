using ScheduleDbManager.Business.DTOMapper;
using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.DAL;
using System;
using System.Linq;

namespace ScheduleDbManager.Business.ScheduleManager
{
    internal class ScheduleManager : IScheduleManager
    {
        #region Method to add new schedule record , return a bool value based on operation success/failure
        public bool AddSchedule(ScheduleDto scheduleDto)
        {
            if (scheduleDto != null)
            {
                IScheduleDataAccess scheduleDataAccess = new ScheduleDataAccess();
                IScheduleMapper mapper = new ScheduleMapper();
                scheduleDataAccess.AddSchedule(mapper.MapToEntity(scheduleDto));
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        public int GetLatestScheduleIdByPersonId(string personId)
        {
            IScheduleDataAccess dataAccess = new ScheduleDataAccess();
            return dataAccess.GetAllScheduleByPersonId(personId).OrderByDescending(i => i.Id).First().Id;
        }
    }
}
