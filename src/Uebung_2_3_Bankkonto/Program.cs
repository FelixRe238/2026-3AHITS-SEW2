// ------------------------------
// Uebung_2_3_Bankkonto
// ------------------------------

using System.ComponentModel.DataAnnotations;

namespace Uebung_2_3_Bankkonto;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Bankkonto konto = new Bankkonto(1000, 0.10, "Morli");
        Console.WriteLine(konto);
        konto.Ein(100);
        Console.WriteLine(konto);
        konto.Aus(50);
        Console.WriteLine(konto);
        konto.JahresAbschluss();
        Console.WriteLine(konto);
        Bankkonto schuerst = new Bankkonto(1000, 10, "Maxus");
        konto.Ueberweisung(400, schuerst);
        Console.WriteLine(konto);
        Console.WriteLine(schuerst);
        Bankkonto x = schuerst.Neueskonto("Resch", 200);
        Console.WriteLine(x);

        
    }
}
