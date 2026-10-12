// ------------------------------
// Uebung_2_2_Rechteck
// ------------------------------

using System.Security.Cryptography.X509Certificates;

namespace Uebung_2_2_Rechteck;

class Rechteck
{
    public double a;
    public double b;
    public  Rechteck() : this(10, 20) {}
    public  Rechteck(double aa, double bb)
    {
        a = aa;
        b = bb;
    }
    public override string ToString()
    {
        return $"Seitenlänge a:{a}, Seitenlänge b:{b}";
    }
    public void Resize()
    {
        if(a < b)
        {
            b -= a;
        }
        else if (a > b)
        {
            a -= b;
        }
        else
        {
            Console.WriteLine("Abzug nicht möglich, da beide Zahlen gleich sind");
        }
    }
    public void Inflate(double prozentwert)
    {
        prozentwert = prozentwert / 100;
        prozentwert += 1;
        a = a * prozentwert;
        b = b * prozentwert;
    }
    public double AspectRatio()
    {
        double seitenverhältnis = a / b;
        return seitenverhältnis;
    }
    public double Area()
    {
        double rechteckArea = a * b;
        return rechteckArea;
    }
    public int Tile(Rechteck r)
    {
        double rechteckArea = a * b;
        double rechteckAreaR = r.a * r.b;
        double hineinpasstAnzD = rechteckArea / rechteckAreaR;
        int hineinpasstAnz = (int)hineinpasstAnzD;
        return hineinpasstAnz;
    }
    public void SetMaxSide(double c)
    {
        
        if(a < b)
        {
            b = c;
        }
        else if (a > b)
        {
            a = c;
        }
        else
        {
            Console.WriteLine("Änderung nicht möglich, da beide Zahlen gleich sind");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Rechteck re2 = new Rechteck();
        Rechteck re = new Rechteck();
        Console.WriteLine(re);
        Console.WriteLine(re.AspectRatio());
        re.Inflate(30);
        Console.WriteLine(re);
        Console.WriteLine(re.Area());
        Console.WriteLine(re.Tile(re2));
       

    }
}
