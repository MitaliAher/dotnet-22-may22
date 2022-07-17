using Azure.Storage.Queues;
using System;

namespace ConnectWithQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("Order with ORD13234 is proccessed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=mitali1;AccountKey=3g/lUx6QV3ORbnr3DgWVgFZTbEAC/TNz4NpekHtjqAZ0NQavuJTHwndwBtE13w+sup/c/q0tWWzm+AStRFt4Sw==;EndpointSuffix=core.windows.net";
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
