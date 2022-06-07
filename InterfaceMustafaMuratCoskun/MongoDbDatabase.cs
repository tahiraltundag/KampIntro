using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceMustafaMuratCoskun
{
    class MongoDbDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("MongoDb Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MongoDb Silindi");
        }

        public void Update()
        {
            Console.WriteLine("MongoDb Güncellendi");    
        }
    }
}
