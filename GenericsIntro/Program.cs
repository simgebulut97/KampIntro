using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Simge");
            Console.WriteLine(isimler.Length);
            isimler.Add("Berker");
            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
