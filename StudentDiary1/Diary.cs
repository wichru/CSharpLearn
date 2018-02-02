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
        // Zmienne - pola inaczej dane
        List<float> ratings;


        // Zachowanie inaczej metody
     
        public void Add_ratings(float rating)
        {
           
            ratings.Add(rating); // METODA DODAWANIA OCENY
        }
        
        public DiaryStatictics ComputerStat()
        {
            DiaryStatictics stats = new DiaryStatictics();
            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();
            
            return stats;
        }
    }
}
