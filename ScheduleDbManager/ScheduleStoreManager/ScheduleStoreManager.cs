using ScheduleDbManager.Business;
using ScheduleDbManager.Business.DTOMapper;
using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.Business.ScheduleManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.ScheduleStoreManager
{
    public class ScheduleStoreManager
    {
        public bool StoreDataToDatabase()
        {
            IScheduleApiData apiData = new ScheduleApiData();
            string jsonString = apiData.GetJsonDataFromApi();
            if(jsonString != string.Empty)
            {
                IJsonProcessor jsonProcessor = new JsonProcessor();
                List<ScheduleDto> deserializedObjects = jsonProcessor.DeserializeJson(jsonString);
                if(deserializedObjects != null)
                {
                    IScheduleManager scheduleManager = new ScheduleManager();
                    IScheduleMapper scheduleMapper = new ScheduleMapper();

                    foreach(ScheduleDto dto in deserializedObjects)
                    {
                        scheduleManager.AddSchedule(dto);
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                {

                return false;
            }
        }

    }
}
