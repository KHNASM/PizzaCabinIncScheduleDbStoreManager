using System.Net;

namespace ScheduleDbManager.Business
{
    internal class ScheduleApiData : IScheduleApiData
    {
        public string GetJsonDataFromApi()
        {
            using WebClient client = new();
            string response = client.DownloadString("http://pizzacabininc.azurewebsites.net/PizzaCabinInc.svc/schedule/2015-12-14");
            return response ?? string.Empty;
        }
    }
}
