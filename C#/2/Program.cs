using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Cколько вам лет?");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваш возраст: " + a);
            //if(a >= 18)
            //{
            //    Console.WriteLine("Вы прошли");
            //}
            //else
            //{
            //    Console.WriteLine("Вы не прошли");
            //}
            //Console.ReadKey();

            //int a = 0;
            //while(a < 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //    Console.ReadKey();


            //}




            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadKey();

            //}

            var a = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int num in a)
            {
                Console.WriteLine(num);
                Console.ReadKey();
            }




        }
    }
}
