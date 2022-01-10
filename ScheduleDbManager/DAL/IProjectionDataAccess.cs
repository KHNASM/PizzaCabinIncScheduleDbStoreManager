using ScheduleDbManager.Domain.Entities;
using System.Collections.Generic;

namespace ScheduleDbManager.DAL
{
    internal interface IProjectionDataAccess
    {
        bool AddProjection(Projection projection);
        bool DeleteProjection(Projection projection);
        List<Projection> GetAllProjectionByScheduleId(int scheduleId);
    }
}