using ScheduleDbManager.Business.DTOs;

namespace ScheduleDbManager.Business.ProjectionManager
{
    internal interface IProjectionManger
    {
        bool AddProjection(int scheduleId, ProjectionDto projectionDto);
    }
}