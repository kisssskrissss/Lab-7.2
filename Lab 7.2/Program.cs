using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._2
{
    class Program
    {
        static void GetOS(int a, out double v, out double s)
        {
         v = a * a * a;
            s = a * a * 6;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
            int x = Convert.ToInt32(Console.ReadLine());
            double V;
            double S;
            GetOS(x, out V, out S);
            Console.WriteLine("V={0:.00} , S={1:.00}",V,S);
            Console.ReadKey();

        }
    }
}
