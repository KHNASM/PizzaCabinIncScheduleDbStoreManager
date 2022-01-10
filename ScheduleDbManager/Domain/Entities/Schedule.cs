using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public int ContractTimeMinutes { get; set; }
        public DateTime Date { get; set; }
        public bool IsFullDayAbsence { get; set; }
        public string Name { get; set; }
        public string PersonId { get; set; }
        public ICollection<Projection> Projections { get; set; }
    }
}
