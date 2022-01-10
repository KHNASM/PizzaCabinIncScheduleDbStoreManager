using ScheduleDbManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.DAL
{
    internal class ProjectionDataAccess : IProjectionDataAccess
    {
        public List<Projection> GetAllProjectionByScheduleId(int scheduleId)
        {
            using ScheduleManagerContext context = new();
            return context.Projections.Where(pr => pr.ScheduleId == scheduleId).ToList();
        }

        public bool AddProjection(Projection projection)
        {
            if (projection != null)
            {
                using ScheduleManagerContext context = new();
                context.Projections.Add(projection);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProjection(Projection projection)
        {
            if (projection != null)
            {
                using ScheduleManagerContext context = new();
                context.Projections.Remove(projection);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
