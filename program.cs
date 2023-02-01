using System;

public class Kostka
{
    public static void Main()
    {
        int kostka = 0;
        Random liczba = new Random();
        string str = String.Empty;
        Console.Clear();
        while (true)
        {
            Console.Write("Iluścienną kostką chcesz grać? ");
            try { kostka = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Podano nieprawidłowe dane!");
                kostka = 0;
            }
            if (kostka < 4) { Console.WriteLine("Kostka ma minimum 4 ściany."); }
            else break;
        }
        Console.Clear();
        while (!str.Equals("q"))
        {
            Console.WriteLine($"Wylosowana liczba to: {liczba.Next(kostka) + 1}\tAby zakończyć wciśnij Q + Enter");
            str = Console.ReadLine();
        }
    }
}