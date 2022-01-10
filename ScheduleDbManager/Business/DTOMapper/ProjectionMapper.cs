using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.Domain.Entities;
using ScheduleDbManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.Business.DTOMapper
{
    internal class ProjectionMapper : IProjectionMapper
    {
        public Projection MapToEntity(ProjectionDto projectionDto)
        {
            Projection output = new Projection();

            if (projectionDto != null)
            {


                output.Color = projectionDto.Color;
                output.Description = projectionDto.Description;
                output.Start = DateTimeHelper.ConvertEpochToDateTime(projectionDto.Start);
                output.Minutes = projectionDto.minutes;
                return output;
            }          
            else
            {
                return null;
            }

        }

        public ProjectionDto MapToDto(Projection projection)
        {

            if (projection != null)
            {
                return new ProjectionDto()
                {
                    Id = projection.Id,
                    Color = projection.Color,
                    Description = projection.Description,
                    Start = projection.Start.ToString(),
                    minutes = projection.Minutes,
                    ScheduleId = projection.ScheduleId
                };
            }
            else
            {
                return null;
            }

        }

    }
}
