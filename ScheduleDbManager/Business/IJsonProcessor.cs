using ScheduleDbManager.Business.DTOs;
using System.Collections.Generic;

namespace ScheduleDbManager.Business
{
    internal interface IJsonProcessor
    {
        List<ScheduleDto> DeserializeJson(string jsonString);
    }
}