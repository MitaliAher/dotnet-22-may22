using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://mitali1.table.core.windows.net"), "FirstTbl", new TableSharedKeyCredential("mitali1", "3g/lUx6QV3ORbnr3DgWVgFZTbEAC/TNz4NpekHtjqAZ0NQavuJTHwndwBtE13w+sup/c/q0tWWzm+AStRFt4Sw=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}
