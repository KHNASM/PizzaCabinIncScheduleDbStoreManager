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
    internal class ScheduleMapper : IScheduleMapper
    {

        // This class performs the mapping between DTOs and Entity Models
        // An efficient way to achieve the same funtionality is to use AutoMapper
        // Automapper was not used due to lack of experince in its implementation in a Class Library
        public Schedule MapToEntity(ScheduleDto scheduleDto)
        {
            
            if (scheduleDto != null)
            {
                Schedule output = new Schedule();
                IProjectionMapper projectionMapper = new ProjectionMapper();
                output.ContractTimeMinutes = scheduleDto.ContractTimeMinutes;
                output.Date = DateTimeHelper.ConvertEpochToDateTime(scheduleDto.Date);
                output.IsFullDayAbsence = scheduleDto.IsFullDayAbsence;
                output.Name = scheduleDto.Name;
                output.PersonId = scheduleDto.PersonId;
                if (scheduleDto.Projection.Count > 0)
                {
                    List<Projection> projectionTemp = new();

                    foreach (ProjectionDto projection in scheduleDto.Projection)
                    { 
                        projectionTemp.Add(projectionMapper.MapToEntity(projection));
                    }

                    output.Projections = projectionTemp;
                }
                return output;
            }
            else
            {
                return null;
            }
        }

        public ScheduleDto MapToDto(Schedule schedule)
        {
            ScheduleDto output = new();
            IProjectionMapper projectionMapper = new ProjectionMapper();
            if (schedule != null)
            {
                output.ContractTimeMinutes = schedule.ContractTimeMinutes;
                output.Date = schedule.Date.ToString();
                output.IsFullDayAbsence = schedule.IsFullDayAbsence;
                output.Name = schedule.Name;
                output.PersonId = schedule.PersonId;
                foreach (var projection in schedule.Projections)
                {
                    output.Projection.Add(projectionMapper.MapToDto(projection));
                }
                return output;
            }
            else
            {
                return null;
            }
        }
    }
}
