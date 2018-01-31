using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LataNaWiek
{
    class Program
    {
        static void Main(string[] args)
        {

            int year;
            Console.WriteLine("Podaj rok: ");
            year = int.Parse(Console.ReadLine());

            if (year <= 100) Console.WriteLine("1");
            if ((year >= 101) && (year <= 200)) Console.WriteLine("Wiek: 2");
            if ((year >= 201) && (year  <= 300)) Console.WriteLine("Wiek: 3");
            if ((year >= 301) && (year  <= 400)) Console.WriteLine("Wiek: 4");
            if ((year >= 401) && (year  <= 500)) Console.WriteLine("Wiek: 5");
            if ((year >= 501) && (year <= 600)) Console.WriteLine("Wiek: 6");
            if ((year >= 601) && (year <= 700)) Console.WriteLine("Wiek: 7");
            if ((year >= 701) && (year <= 800)) Console.WriteLine("Wiek: 8");
            if ((year >= 801) && (year <= 900)) Console.WriteLine("Wiek: 9");
            if ((year >= 901) && (year <= 1000)) Console.WriteLine("Wiek: 10");
            if ((year >= 1001) && (year <= 1100)) Console.WriteLine("Wiek: 11");
            if ((year >= 1101) && (year <= 1200)) Console.WriteLine("Wiek: 12");
            if ((year >= 1201) && (year <= 1300)) Console.WriteLine("Wiek: 13");
            if ((year >= 1301) && (year <= 1400)) Console.WriteLine("Wiek: 14");
            if ((year >= 1401) && (year <= 1500)) Console.WriteLine("Wiek: 15");
            if ((year >= 1501) && (year <= 1600)) Console.WriteLine("Wiek: 16");
            if ((year >= 1601) && (year <= 1700)) Console.WriteLine("Wiek: 17");
            if ((year >= 1701) && (year <= 1800)) Console.WriteLine("Wiek: 18");
            if ((year >= 1801) && (year <= 1900)) Console.WriteLine("Wiek: 19");
            if ((year >= 1901) && (year <= 2000)) Console.WriteLine("Wiek: 20");
            if ((year >= 2001) && (year <= 2100)) Console.WriteLine("Wiek: 21");


            Console.ReadKey();
        }
    }
}


