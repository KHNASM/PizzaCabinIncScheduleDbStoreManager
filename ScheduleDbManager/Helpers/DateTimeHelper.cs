using System;

namespace ScheduleDbManager.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime ConvertEpochToDateTime(string epoch)
        {
            String getTimeFromJsonString = epoch.Substring(epoch.IndexOf("(") + 1, ((epoch.IndexOf("+") - 1) - (epoch.IndexOf("("))));  //Extracting the Millisecond time value from JSon object
            long timeInMiliSeconds = long.Parse(getTimeFromJsonString);
            DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeSeconds(timeInMiliSeconds/1000); //Converting the Epoch/Unix timestamp to human readable format (i.e. DataTime)
            return dateTime.DateTime;
        }
    }
}
