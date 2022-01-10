using ScheduleDbManager.Business;
using ScheduleDbManager.Helpers;
using ScheduleDbManager.ScheduleStoreManager;
using System;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            ScheduleStoreManager storeManager = new ScheduleStoreManager();

            Console.WriteLine(storeManager.StoreDataToDatabase());
            Console.ReadLine();

        }
    }
}
