using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTekrar
{

    class Program
    {
        static void Main(string[] args)
        {

            int yas;
           
            Console.Write("Yaşınızı giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());
           

            if (yas>=18)
            {
                Console.Write("Ehliyet alabilir");
            }
            else
            {
                Console.Write("Ehliyet alamaz");
            }

            Console.ReadKey();
        }

    }
}
