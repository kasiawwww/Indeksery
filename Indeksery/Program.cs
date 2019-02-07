using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexersClasses;

namespace Indeksery
{
    class Program
    {
        static void Main(string[] args)
        {
            Names names = new Names(5);
            names[0] = "Roman";
            names[1] = "Aśka";
            names[2] = "Krzyś";

            Year years = new Year(3);
            years["Roman"] = 1980;


            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("------------------");
            Console.WriteLine(years["Roman"]);
            Console.Read();
        }
    }
}
