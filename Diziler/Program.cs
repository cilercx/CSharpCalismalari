using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3] { "Çiler", "Burak", "Liya" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
