namespace Studia
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
            Console.WriteLine ("0 - przerwanie gry");
            string[] tabela = {"wyjście", "kamień", "papier", "nożyce"};
            bool wyborGraczBool;
            int i, wyborGracz, wyborKomp, zwyciestwaKomp = 0, zwyciestwaGracz = 0;
            for (i=1;i<=10;i++)
            {
                wyborKomp=losowa.Next(1,4);
                Console.WriteLine($"\nRUNDA {i}!");
                Console.WriteLine ("Użytkowniku, podaj swój typ: ");
                wyborGraczBool = (Int32.TryParse (Console.ReadLine(), out wyborGracz));
                if (wyborGraczBool && wyborGracz!=0)
                {
                    Console.WriteLine ($"Wybór gracza to: {tabela[wyborGracz]}");
                    Console.WriteLine ($"Wybór komputera to: {tabela[wyborKomp]}");
                }
                if (wyborGraczBool && (wyborGracz==1 || wyborGracz==2 || wyborGracz==3))
                {
                    if (wyborGracz==wyborKomp)
                    {
                        Console.WriteLine ("Mamy remis - powtórka rundy");
                        i--;
                    }
                    else if ((wyborGracz==1 && wyborKomp==3) || (wyborGracz==2 && wyborKomp==1) || (wyborGracz==3 && wyborKomp==2))
                    {
                        Console.WriteLine ("Tę rundę wygrywa GRACZ!");
                        zwyciestwaGracz++;
                    }
                    else
                    {
                        Console.WriteLine ("Tę rundę wygrywa KOMPUTER!");
                        zwyciestwaKomp++;
                    }
                }
                else
                {
                    if (wyborGraczBool && wyborGracz==0)
                    {
                        Console.WriteLine ("Wybrano przerwanie gry");
                        break;
                    }
                    Console.WriteLine ("Powtórz, wprowadzono nieprawidłową liczbę");
                    i--;
                }
            }
            i--;
            Console.WriteLine ($"\nOstateczny wynik po {i} rundach to:");
            if (zwyciestwaGracz==zwyciestwaKomp)
            {
                Console.WriteLine ("REMIS OBU ZAWODNIKÓW");
            }
            if (zwyciestwaGracz>zwyciestwaKomp)
            {
                Console.WriteLine ("ZWYCIĘŻYŁ GRACZ!");
            }
            if (zwyciestwaGracz<zwyciestwaKomp)
            {
                Console.WriteLine ("ZWYCIĘŻYŁ KĄKUTER!");
            }
            Console.WriteLine ($"Wynik: CZŁOWIEK {zwyciestwaGracz} : {zwyciestwaKomp} KOMPUTER");
            Console.WriteLine ("Wciśnij aby zakończyć");
            Console.ReadKey(true);

        }
    }
}