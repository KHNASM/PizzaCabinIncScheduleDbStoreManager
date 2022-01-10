using ScheduleDbManager.Business.DTOs;
using ScheduleDbManager.Business.RootClassMock;
using System.Collections.Generic;
using System.Text.Json;

namespace ScheduleDbManager.Business
{
    internal class JsonProcessor : IJsonProcessor
    {
        public List<ScheduleDto> DeserializeJson(string jsonString)
        {
            ScheduleResult result = new();
            var setNewRootElement = JsonDocument.Parse(jsonString).RootElement.GetProperty("ScheduleResult").ToString();
            result = JsonSerializer.Deserialize<ScheduleResult>(setNewRootElement);
            return result.Schedules;
        }
    }
}
