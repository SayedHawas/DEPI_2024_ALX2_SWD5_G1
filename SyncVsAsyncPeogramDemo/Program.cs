using System.Diagnostics;

namespace SyncVsAsyncPeogramDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Synchronous Vs Asynchronous");
            //Synchronous
            Console.WriteLine("Synchronous");
            var swSync = Stopwatch.StartNew();
            DoSyncTasks();
            swSync.Stop();
            Console.WriteLine($"Call Tasks take Time {swSync.ElapsedMilliseconds} ms");

            //Asynchronous
            Console.WriteLine("Asynchronous");
            var swAsync = Stopwatch.StartNew();
            DoSyncTasksAsync().Wait();
            swAsync.Stop();
            Console.WriteLine($"Call Tasks take Time {swAsync.ElapsedMilliseconds} ms");

            Console.ReadLine();

        }

        //Create Method To call Task1 & Task2
        static void DoSyncTasks()
        {
            SaveDatabase();
            SendSMS();
        }

        static async Task DoSyncTasksAsync()
        {
            Task task1 = SaveDatabaseAsync();
            Task task2 = SendSMSAsync();
            await Task.WhenAll(task1, task2);
        }


        //Create Method Task1
        static void SaveDatabase()
        {
            Console.WriteLine("Start the Task1");
            //Do Something
            Thread.Sleep(5000);
            Console.WriteLine("Finished the Task1");
        }
        //Create Method Task2
        static void SendSMS()
        {
            Console.WriteLine("Start the Task2");
            //Do Something
            Thread.Sleep(5000);
            Console.WriteLine("Finished the Task2");
        }

        // async Task Await 
        //Create Method Task1
        static async Task SaveDatabaseAsync()
        {
            Console.WriteLine("Start the Task1");
            //Do Something
            await Task.Delay(5000);
            Console.WriteLine("Finished the Task1");
        }
        //Create Method Task2
        static async Task SendSMSAsync()
        {
            Console.WriteLine("Start the Task2");
            //Do Something
            await Task.Delay(5000);
            Console.WriteLine("Finished the Task2");
        }

    }
}
