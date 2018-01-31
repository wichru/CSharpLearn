using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary1
{
    class Diary
    {
        // Zmienne - pola
        List<float> ratings = new List<float>();


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
