using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary1
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

        public void Add_ratings(float rating)
        {
            ratings.Add(rating);
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
