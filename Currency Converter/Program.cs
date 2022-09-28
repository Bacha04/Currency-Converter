using System;
using System.Runtime;


namespace Convert
{
    class Converter
    {

        static void Main(string[] args)
        {
            decimal UsdToUah = 36.82M;
            decimal EuToUah = 35.41M;
            decimal USD1;
            decimal USD2;
            decimal EUR1;
            decimal EUR2;
            string valute;
            string d = "USD";
            string e = "EUR";


            Console.WriteLine("Введіть вашу валюту: USD / EUR");

            valute = Console.ReadLine();

            bool usd = valute.Contains(d);
            bool eur = valute.Contains(e);
            if (usd)
            {
                Console.WriteLine("Введіть сумму в USD");
                USD1 = decimal.Parse(Console.ReadLine());
                USD2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine(USD1 + "USD в UAH = " + USD1 * UsdToUah);
                Console.WriteLine(USD2 + "USD в UAH = " + USD2 * UsdToUah);
            }
            else if (eur)
            {
                Console.WriteLine("Введіть сумму в EUR");
                EUR1 = decimal.Parse(Console.ReadLine());
                EUR2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine(EUR1 + "EUR в UAH = " + EUR1 * EuToUah);
                Console.WriteLine(EUR2 + "EUR в UAH = " + EUR2 * EuToUah);
            }
            else
            {
                Console.WriteLine("Непраильне введення.Виберіть валюту із двох зазначених");
                valute = Console.ReadLine();

            }

        }
    }
}

