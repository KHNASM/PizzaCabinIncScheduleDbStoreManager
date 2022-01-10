using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.Business.DTOs
{
    public class ScheduleDto
    {
        public int? Id { get; set; }
        public int ContractTimeMinutes { get; set; }
        public string Date { get; set; }
        public bool IsFullDayAbsence { get; set; }
        public string Name { get; set; }
        public string PersonId { get; set; }
        public List<ProjectionDto> Projection { get; set; }
    }
}
