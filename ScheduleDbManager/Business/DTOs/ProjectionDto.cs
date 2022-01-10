using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.Business.DTOs
{
    public class ProjectionDto
    {
        public int? Id { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public int minutes { get; set; }
        public int? ScheduleId { get; set; }
    }
}
