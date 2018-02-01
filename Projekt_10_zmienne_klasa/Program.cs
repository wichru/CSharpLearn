using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_10_zmienne_referencyjne
{
    class Program
    {
        //zmienne referencyjne
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // zmienne referencyjne - nie przechowują bezpośrendio obiektów tak jak typy proste np int = 2 (przechowuje 2)
            diary.Add_ratings(3);     // przechowują za to wskaźnik do obiektu
            diary.Add_ratings(5);

            //diary = new Diary(); // zmienna 'diary' wskazuje na nowy obiekt - 'Diary' - więc jego zawartość będzie taka jak nowego obiektu (logiczne)
            //diary.Add_ratings(8);

            Diary diary2 = diary; // zmienne wstazują na ten sam obiekt, obiekt Diary przechowuje 3 oceny dla każdej zmiennej
            diary2.Add_ratings(8);
        }
    }
}
