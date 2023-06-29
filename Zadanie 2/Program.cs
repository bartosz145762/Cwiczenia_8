using System;

struct Student
{
    public int NumerIndeksu;
    public string Imie;
    public string Nazwisko;
    public int Wiek;
    public string Kierunek;
    public float SredniaOcen;
}

struct Przedmiot
{
    public int NumerPrzedmiotu;
    public string NazwaPrzedmiotu;
    public string Prowadzący;
    public int GodzinyPrzedmiotu;
    public string Wydzial;
}

struct Nauczyciel
{
    public int NumerNauczyciela;
    public string Imie;
    public string Nazwisko;
    public string Wydzial;
    public string Tytul;
    public int LataDoświadczenia;
}
public class Program
{
    public static void Main()
    {
        Console.Title = "Zadanie 2";

        Console.WriteLine("Zdefiniowanie struktur do opisu");
        Console.WriteLine();

        Student student1;
        student1.NumerIndeksu = 12345;
        student1.Imie = "Jan";
        student1.Nazwisko = "Kowalski";
        student1.Wiek = 20;
        student1.Kierunek = "Informatyka";
        student1.SredniaOcen = 4.5f;

        Przedmiot przedmiot1;
        przedmiot1.NumerPrzedmiotu = 101;
        przedmiot1.NazwaPrzedmiotu = "Programowanie";
        przedmiot1.Prowadzący = "Dr. Anna Nowak";
        przedmiot1.GodzinyPrzedmiotu = 5;
        przedmiot1.Wydzial = "Wydział Informatyki";

        Nauczyciel nauczyciel1;
        nauczyciel1.NumerNauczyciela = 1001;
        nauczyciel1.Imie = "Adam";
        nauczyciel1.Nazwisko = "Nowak";
        nauczyciel1.Wydzial = "Wydział Informatyki";
        nauczyciel1.Tytul = "Profesor";
        nauczyciel1.LataDoświadczenia = 10;

        Console.WriteLine("Informacje o studencie:");
        Console.WriteLine("Numer indeksu: " + student1.NumerIndeksu);
        Console.WriteLine("Imię i nazwisko: " + student1.Imie + " " + student1.Nazwisko);
        Console.WriteLine("Wiek: " + student1.Wiek);
        Console.WriteLine("Kierunek: " + student1.Kierunek);
        Console.WriteLine("Średnia ocen: " + student1.SredniaOcen);

        Console.WriteLine();

        Console.WriteLine("Informacje o przedmiocie:");
        Console.WriteLine("Numer przedmiotu: " + przedmiot1.NumerPrzedmiotu);
        Console.WriteLine("Nazwa przedmiotu: " + przedmiot1.NazwaPrzedmiotu);
        Console.WriteLine("Prowadzący: " + przedmiot1.Prowadzący);
        Console.WriteLine("Godziny przedmiotu: " + przedmiot1.GodzinyPrzedmiotu);
        Console.WriteLine("Wydział: " + przedmiot1.Wydzial);

        Console.WriteLine();

        Console.WriteLine("Informacje o nauczycielu akademickim:");
        Console.WriteLine("Numer nauczyciela: " + nauczyciel1.NumerNauczyciela);
        Console.WriteLine("Imię i nazwisko: " + nauczyciel1.Imie + " " + nauczyciel1.Nazwisko);
        Console.WriteLine("Wydział: " + nauczyciel1.Wydzial);
        Console.WriteLine("Tytuł: " + nauczyciel1.Tytul);
        Console.WriteLine("Lata doświadczenia: " + nauczyciel1.LataDoświadczenia);

        Console.ReadLine();
    }
}