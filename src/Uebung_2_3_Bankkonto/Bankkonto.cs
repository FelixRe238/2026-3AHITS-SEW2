
class Bankkonto
{
    double Kontostand;
    double Zinssatz;
    string Kontoinhaber;


    public Bankkonto() : this(500, 0.5, "name") { }
    public Bankkonto(double kontostand, double zinssatz, string kontoinhaber)
    {
        Kontostand = kontostand;
        Zinssatz = zinssatz;
        Kontoinhaber = kontoinhaber;

    }
    public void Ein(double einzahlung)
    {
        Kontostand += einzahlung;
    }
    public void Aus(double auszahlung)
    {
        Kontostand -= auszahlung;
    }
    public double JahresAbschluss()
    {
        double zinsen = Kontostand * Zinssatz;
        Kontostand += zinsen;
        return zinsen;

    }
    public void ZinsPlus(double zinssatzErhoehung)
    {
        Zinssatz += zinssatzErhoehung;
    }
    public void ZinsMinus(double zinssatzVerminderung)
    {
        Zinssatz -= zinssatzVerminderung;
    }
    public override string ToString()
    {
        return $"Kontostand: {Kontostand}, Zinssatz: {Zinssatz}, Kontoinhaber: {Kontoinhaber}";
    }
    public void Ueberweisung(double ueberweisungsbetrag, Bankkonto Ziel)
    {
        Ziel.Kontostand += ueberweisungsbetrag;
        Kontostand -= ueberweisungsbetrag;

    }
    public Bankkonto Neueskonto(string Neu, double Wert)
    {
        Bankkonto x = new Bankkonto(0, 0.1,Neu);
        Ueberweisung(Wert, x);
        
        return x;
    }
    

}
