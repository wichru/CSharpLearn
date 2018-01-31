using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_WriteLine
{
    class WriteLine
    {
        static void Main(string[] args)
        {
            for (; ;) // pętla w nieskończoność - program uruchamia się cały czas po naciśnięciu ENTER na końcu
            {
             // odniesienie do metod, szczegóły kodu poniżej
                Greeting();
                Age();
                Settings();
            }
        }
        // utworzenie metody przez zaznaczenie fragmentu kodu, prawy przycisk QUICK ACTIONS.... etc.
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void Age()
        {
            Console.Write("Ile masz lat? ");
            int wiek;
            /* Dlaczego bool - jeśli byłby int wyskoczyłby błąd bo użytkownik wprowadza najpierw wartość string a teraz int dlatego
            trzeba zastosować metodę PARSE (lub TryParse - żeby nie wyskoczył błąd przy wpisaniu liter zamiast cyfr przez użytkownika*/
            bool result = int.TryParse(Console.ReadLine(), out wiek);

            if (wiek >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo zią! możesz kupić browara!");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś niepoprawny wiek, kretynie! Popraw to wpisując wartość liczbową");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Spadaj łebku!");
            }
        }

        private static void Greeting()
        {
            Console.Write("Wpisz imię debilu: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
