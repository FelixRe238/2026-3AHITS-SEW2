// ------------------------------
// Uebung_2_1_Schulklasse
// ------------------------------

using System.Net.Http.Headers;

namespace Uebung_2_1_Schulklasse;

class Schulklasse
{
    public int anzahlSchueler;
    public string nameKlassenVorstand;

    public Schulklasse() : this(0, "unbekannt") {}

    public Schulklasse(int AnzahlSchueler, string NameKlassenVorstand)
    {
        anzahlSchueler = AnzahlSchueler;
        nameKlassenVorstand = NameKlassenVorstand;
    }
    public override string ToString()
    {
        return $"Anzahl der Schüler:{anzahlSchueler}, Name des Klassenvorstands:{nameKlassenVorstand}";
    }
    public void Dazu()
    {
        anzahlSchueler += 1;
    }
    public void Raus(int anzahlEntfernen)
    {
        anzahlSchueler -= anzahlEntfernen;
    }
    public void KlassenwechselNach(Schulklasse wechselKlasse)
    {
        anzahlSchueler -=1;
        wechselKlasse.anzahlSchueler +=1;
    }
}



class Program
{

    static void Main(string[] args)
    {
        Schulklasse AHITS = new Schulklasse(22, "Strasser");
        Schulklasse AHELS = new Schulklasse(20, "Falkner");
        Schulklasse HLW = new Schulklasse();
        AHITS.KlassenwechselNach(AHELS); 
        Console.WriteLine(HLW);
        Console.WriteLine(AHITS);
        AHELS.Dazu();
        AHELS.Raus(2);
        Console.WriteLine(AHELS);
    }


}

