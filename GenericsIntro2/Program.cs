using System;

namespace GenericsIntro2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tahir");

            Console.WriteLine(isimler);

        }
    }
}
