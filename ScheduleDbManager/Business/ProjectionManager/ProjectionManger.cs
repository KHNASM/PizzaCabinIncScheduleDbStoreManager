using ScheduleDbManager.Business.DTOMapper;
using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.Business.ProjectionManager
{
    internal class ProjectionManger : IProjectionManger
    {
        public bool AddProjection(int scheduleId, ProjectionDto projectionDto)
        {
            if (projectionDto != null)
            {
                IProjectionDataAccess dataAccess = new ProjectionDataAccess();
                IProjectionMapper mapper = new ProjectionMapper();
                projectionDto.ScheduleId = scheduleId;
                dataAccess.AddProjection(mapper.MapToEntity(projectionDto));
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
