using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // wywołany został konstruktor domyślny => tworzy obiekt któy jest instancje klasy poprzez konstruktor 'new' 

            //diary.Add_ratings(5);
            //diary.Add_ratings(8.5f); // trzeba zawsze dodawać na końcu wartości przy typie float litere 'f'
            //diary.Add_ratings(4.5f); // tak żeby kompilator nie stosował typu double który jest ustawiany automatycznie

            //float avg = diary.CalcAverage();
            //float max = diary.MaxRating();
            //float min = diary.MinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10:");
                float rating;                                                  // <= zadeklarowana wcześniej zmienna
                bool result = float.TryParse(Console.ReadLine(), out rating); // żeby zabezpieczyć przed wpisaniem litery zamiast cyfry trzeba dodać zmienną BOOL i zadeklarować result
                                                                              // na końcu dodać 'out' i parsowaną zmienną która wcześniej musi być osobno zadeklarowana


                // jeżeli użytkownik wprowadzi ocene 11 pętla ma się przerwać stąd:
                if (rating == 11)
                {
                    break;
                }
                if (result)
                {
                    if (rating > 0 && rating <=10)
                    {
                        diary.Add_ratings(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba! Podaj liczbę z zakresu 1 - 1o");
                    }
                
                    
                }
                
            }
            Console.WriteLine("Średnia twoich ocen to:" + diary.CalcAverage());
            Console.WriteLine("Najwyższa ocena to:" + diary.MaxRating());
            Console.WriteLine("Najniższa ocena to:" + diary.MinRating());
            Console.ReadKey();
        }
    }
}