using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice_dzialajace
{
    class Tablice_dzialajace
    {
        static void Main()
        {
            string[] tablice = new string[]
        {
            "DiNapoli", "Line", "Bulshit", "Monitor"
        };
            int length = tablice.Length;
            string lastElement = tablice[length - 1];
            Console.WriteLine(tablice.Length);
            
        }
        //class Tablice_dzialajace
        //{
        //    static void Main()
        //    {
        //        string[] Tablica = new string[];
        //        {
        //            "DiNapoli", "Line", "Bulshit", "Monitor"
        //        };
        //        int TablicaLength = Tablica.Length;
        //        Console.WriteLine(TablicaLength);
        //    }
        //}
    }
}