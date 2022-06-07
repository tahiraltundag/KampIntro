using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditService
    {

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }

    }
}
