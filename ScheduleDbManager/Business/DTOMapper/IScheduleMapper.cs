using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.Domain.Entities;

namespace ScheduleDbManager.Business.DTOMapper
{
    internal interface IScheduleMapper
    {
        ScheduleDto MapToDto(Schedule schedule);
        Schedule MapToEntity(ScheduleDto scheduleDto);
    }
}