using System;

enum Płeć
{
    Mężczyzna,
    Kobieta
}

struct Student
{
    public string nazwisko;
    public int numerAlbumu;
    public float ocena;
    public Płeć płeć;
}

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Zadanie 4";

        Console.WriteLine("Program pobierający informację o studentach oraz wyliczający średnią grupy");
        Console.WriteLine();

        Student[] studenci = new Student[5];

        for (int i = 0; i < studenci.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Wprowadź informacje dla studenta {i + 1}:");
            Console.WriteLine();
            WypełnijInformacjeStudenta(ref studenci[i]);
        }

        Console.WriteLine("\nGrupa studentów:");
        foreach (Student student in studenci)
        {
            WyświetlInformacjeStudenta(student);
        }

        float średniaOcena = ObliczŚredniąOcenę(studenci);
        Console.WriteLine($"\nŚrednia ocena grupy: {średniaOcena}");

        Console.ReadLine();
    }

    static void WypełnijInformacjeStudenta(ref Student student)
    {
        Console.Write("Nazwisko: ");
        student.nazwisko = Console.ReadLine();

        Console.Write("Numer albumu: ");
        student.numerAlbumu = int.Parse(Console.ReadLine());

        Console.Write("Ocena: ");
        float ocena = float.Parse(Console.ReadLine());
        student.ocena = Math.Max(2.0f, Math.Min(5.0f, ocena));

        Console.Write("Płeć (M/K): ");
        string płećInput = Console.ReadLine();
        student.płeć = (płećInput.ToLower() == "m") ? Płeć.Mężczyzna : Płeć.Kobieta;
        Console.WriteLine();
    }

    static float ObliczŚredniąOcenę(Student[] studenci)
    {
        float suma = 0;
        foreach (Student student in studenci)
        {
            suma += student.ocena;
        }
        return suma / studenci.Length;
    }

    static void WyświetlInformacjeStudenta(Student student)
    {
        Console.WriteLine($"Nazwisko: {student.nazwisko}, Numer albumu: {student.numerAlbumu}, Ocena: {student.ocena}, Płeć: {student.płeć}");
    }
}