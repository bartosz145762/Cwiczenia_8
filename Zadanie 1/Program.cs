using System;

public enum DzienTygodnia
{
    Poniedzialek = 1,
    Wtorek = 2,
    Sroda = 3,
    Czwartek = 4,
    Piatek = 5,
    Sobota = 6,
    Niedziela = 7
}

public enum EtapPrania
{
    Wypelnianie,
    Pranie,
    Plukanie,
    Wirowanie,
    Suszenie
}

public enum Posilek
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum BierkaSzachowa
{
    Pionek,
    Wieza,
    Skoczek,
    Goniec,
    Hetman,
    Krol
}

public class Program
{
    public static void Main()
    {
        Console.Title = "Zadanie 1";

        Console.WriteLine("Zdefiniowanie typów wyliczeniowych");
        Console.WriteLine();

        DzienTygodnia dzien = DzienTygodnia.Wtorek;
        Console.WriteLine("Dzisiaj jest: " + dzien);

        EtapPrania etap = EtapPrania.Pranie;
        Console.WriteLine("Obecny etap prania: " + etap);

        Posilek posilek = Posilek.Obiad;
        Console.WriteLine("Aktualny posiłek: " + posilek);

        BierkaSzachowa bierka = BierkaSzachowa.Skoczek;
        Console.WriteLine("Wybrana bierka szachowa: " + bierka);

        Console.ReadLine();
    }
}