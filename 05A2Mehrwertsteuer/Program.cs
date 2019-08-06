using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05A2Mehrwertsteuer
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal brutto, netto, mehrwertsteuer;
            decimal mehrwertsteuer_satz = (decimal)0.19;

            Console.Write("Bitte eingeben Sie den Bruttobetrag: ");
            if ( ! decimal.TryParse(Console.ReadLine(), out brutto))
            {
                Console.WriteLine("Eingabe ungültig!");
            }
            else
            {
                netto = brutto / (1 + mehrwertsteuer_satz);
                mehrwertsteuer = brutto - netto;

                Console.WriteLine("Netto  {0,8:F2}", netto);
                Console.WriteLine("Steuer {0,8:F2}", mehrwertsteuer);
            }
        }
    }
}
