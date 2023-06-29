using System;

public enum Rzadkosc
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Broń,
    Zbroja,
    Amulet,
    Pierścien,
    Hełm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public float Waga;
    public int Wartość;
    public Rzadkosc Rzadkość;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public void Wypelnij(float waga, int wartosc, Rzadkosc rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartość = wartosc;
        Rzadkość = rzadkosc;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Nazwa: {NazwaWlasna}");
        Console.WriteLine($"Typ: {Typ}");
        Console.WriteLine($"Rzadkość: {Rzadkość}");
        Console.WriteLine($"Wartość: {Wartość}");
        Console.WriteLine($"Waga: {Waga}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.Title = "Zadanie 3";

        Console.WriteLine("Program losujący przedmioty ze skrzynki");
        Console.WriteLine();

        Przedmiot[] skrzynka = new Przedmiot[4];

        WypelnijPrzedmiot(skrzynka, 0, 2.5f, 100, Rzadkosc.Powszechny, TypPrzedmiotu.Broń, "Miecz");
        WypelnijPrzedmiot(skrzynka, 1, 3.0f, 200, Rzadkosc.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
        WypelnijPrzedmiot(skrzynka, 2, 1.0f, 50, Rzadkosc.Unikalny, TypPrzedmiotu.Amulet, "Amulet Mocy");
        WypelnijPrzedmiot(skrzynka, 3, 0.5f, 500, Rzadkosc.Epicki, TypPrzedmiotu.Pierścien, "Pierscien Potęgi");

        Przedmiot losowyPrzedmiot = WylosujPrzedmiot(skrzynka);
        Console.WriteLine("Wylosowany przedmiot:");
        Console.WriteLine();
        losowyPrzedmiot.Wyswietl();

        Console.ReadLine();
    }

    public static void WypelnijPrzedmiot(Przedmiot[] skrzynka, int indeks, float waga, int wartosc, Rzadkosc rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Wypelnij(waga, wartosc, rzadkosc, typ, nazwaWlasna);
        skrzynka[indeks] = przedmiot;
    }

    public static Przedmiot WylosujPrzedmiot(Przedmiot[] skrzynka)
    {
        Random rand = new Random();
        int losowaRzadkosc = rand.Next(1, 11);

        Rzadkosc rzadkosc;

        if (losowaRzadkosc <= 6)
            rzadkosc = Rzadkosc.Powszechny;
        else if (losowaRzadkosc <= 9)
            rzadkosc = Rzadkosc.Rzadki;
        else if (losowaRzadkosc <= 10)
            rzadkosc = Rzadkosc.Unikalny;
        else
            rzadkosc = Rzadkosc.Epicki;

        Przedmiot[] dostepnePrzedmioty = Array.FindAll(skrzynka, p => p.Rzadkość == rzadkosc);
        int losowyIndeks = rand.Next(0, dostepnePrzedmioty.Length);

        return dostepnePrzedmioty[losowyIndeks];
    }
}