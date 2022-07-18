using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://levelupsolutions24.table.core.windows.net"), "tblSample", new TableSharedKeyCredential("levelupsolutions24", "NmrzBu37ickJPXSeXgdFjfswwihqa0g0Qg/wkCT+w1Oz+lGLo3bxbARgF6U+ilCpjADNwKpmbQ1I+ASteNcxlg=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}
