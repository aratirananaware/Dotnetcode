using System;
using Azure.Storage.Queues;
namespace ConnectwithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("Order with ORD13234 is proccessed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=levelupsolutions24;AccountKey=NmrzBu37ickJPXSeXgdFjfswwihqa0g0Qg/wkCT+w1Oz+lGLo3bxbARgF6U+ilCpjADNwKpmbQ1I+ASteNcxlg==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionstring, "sample-queue");
            queueClient.CreateIfNotExists();
            if (queueClient.Exists())
            {
                queueClient.SendMessage(message);
            }
            Console.WriteLine("Message is inserted");
        }
    }
}
