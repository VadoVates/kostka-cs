namespace PROG
{
    class  Program
    {
        static void Main (string [] args)
        {
            Random losowa = new Random ();
            Console.WriteLine ("PROGRAM DO GRY W KAMIEŃ-PAPIER-NOŻYCE");
            Console.WriteLine ("Gra toczy się do 10 rozstrzygnięć (nie ma remisów)");
            Console.WriteLine ("Wprowadź:");
            Console.WriteLine ("1 - kamień");
            Console.WriteLine ("2 - papier");
            Console.WriteLine ("3 - nożyce");
            string[] tabela = {"kamień", "papier", "nożyce"};
            string wyborGraczString;
            int wyborGracz, wyborKomp, zwyciestwaKomp = 0, zwyciestwaGracz = 0;
            wyborKomp=Convert.ToChar(losowa.Next(1,4));
            for (int i=1;i<=10;i++)
            {
                wyborKomp=losowa.Next(0,3);
                Console.WriteLine ("Użytkowniku, podaj swój typ: ");
                wyborGraczString = Console.ReadLine();
                Console.WriteLine ($"Wybór komputera to: {tabela[wyborKomp]}");
                if (!Int32.TryParse (wyborGraczString, out wyborGracz))
                {
                    Console.WriteLine ("Powtórz, wprowadzono nieprawidłową liczbę");
                    i--;
                }
            }
            
        }
    }
}