using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceMustafaMuratCoskun
{
    class DatabaseManager
    {
        public void AddDatabase(IDatabase database)
        {
            database.Add();
        }

        public void DeleteDatabase(IDatabase database)
        {
            database.Delete();
        }

        public void UpdateDatabase(IDatabase database)
        {
            database.Update();
        }
    }
}
