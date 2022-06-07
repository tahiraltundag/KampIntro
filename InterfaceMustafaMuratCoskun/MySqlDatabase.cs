using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceMustafaMuratCoskun
{
    class MySqlDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("MySql eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MySql silindi");
        }

        public void Update()
        {
            Console.WriteLine("MySql güncellendi");
        }
    }
}
