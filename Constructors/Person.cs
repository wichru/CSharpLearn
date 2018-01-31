using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id, age;
        string firstName, lastName, address, gender;

        public Person() // konstruktor domyślny - skrót CTOR
        {
            id = 1;
            firstName = "Jan";
            lastName = "Kowalski";
            age = 29;
        }
        public Person(int id, string firstName, string lastName, string address, string gender, int age) // konstruktor w którym przekazywane są parametry do inicjalizacji pól
        {
            this.id = id; // THIS przypisuje ID z klasy do ID w konstruktorze
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.gender = gender;
            this.age = age;

        }
        public Person(int id, string firstName, string lastName) // parametry konstruktora
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            address = "Kraków"; // jeśli założymy że adres zawsze będzie Kraków to nie trzeba przekazywać tego do konstruktora jako parametr (to na górze)
            age = 18;           // jw.
        }
        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
