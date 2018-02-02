using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_10_zmienne_referencyjne
{
    class Diary
    {
        public Diary() // konstruktor domyślny skrót - CTOR i x2 TAB
        {
            ratings = new List<float>(); // inicjalizacja pól w konstruktorze
        }
        // Zmienne - pola
        List<float> ratings;


        // Zachowanie, metody
        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">nowa ocena</param>
        public void Add_ratings(float rating)
        {
            ratings.Add(rating); // Metoda dodająca nową ocene
        }

        public float CalcAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float MaxRating ()
        {
            return ratings.Max();
        }
        public float MinRating()
        {
            return ratings.Min();
        }
    }
}
