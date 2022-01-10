using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.Domain.Entities;

namespace ScheduleDbManager.Business.DTOMapper
{
    internal interface IProjectionMapper
    {
        ProjectionDto MapToDto(Projection projection);
        Projection MapToEntity(ProjectionDto projectionDto);
    }
}