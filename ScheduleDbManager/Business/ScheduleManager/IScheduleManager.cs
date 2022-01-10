using ScheduleDbManager.Business.DTOs;

namespace ScheduleDbManager.Business.ScheduleManager
{
    internal interface IScheduleManager
    {
        bool AddSchedule(ScheduleDto scheduleDto);
        int GetLatestScheduleIdByPersonId(string personId);
    }
}