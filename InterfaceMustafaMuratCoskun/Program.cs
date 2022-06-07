using System;

namespace InterfaceMustafaMuratCoskun
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.AddDatabase(new MongoDbDatabase());
            databaseManager.DeleteDatabase(new MySqlDatabase());
        }
    }
}
