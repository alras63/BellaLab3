using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //переменные
            int a, b;

            //Запрашиваем a
            Console.WriteLine("Введите a");
            Console.Write("a =");
            string aStr = Console.ReadLine();
            while(!int.TryParse(aStr, out a))
            {
                Console.WriteLine("Не число!");
                aStr = Console.ReadLine();
            }

            //Запрашиваем b
            Console.WriteLine("Введите b");
            Console.Write("b =");
            string bStr = Console.ReadLine();
            while (!int.TryParse(bStr, out b))
            {
                Console.WriteLine("Не число!");
                bStr = Console.ReadLine();
            }
            if(a < b) {
                rec(a, b, 0);

            }

            if (a > b)
            {
                rec(a, b, 1);

            }

            Console.ReadLine();
        }

        static void rec(int a, int b, int type)
        {
        
            if (a<= b && type == 0)
            {
   
                Console.WriteLine(a);

                rec(a + 1, b, 0);


            }

            if (a >= b && type == 1)
            {

                Console.WriteLine(a);

                rec(a - 1, b, 1);


            }
        }
    }
}
