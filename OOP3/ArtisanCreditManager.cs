using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanCreditManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi hesaplandı");
        }
    }
}
