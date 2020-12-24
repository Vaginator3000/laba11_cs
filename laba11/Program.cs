using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Одномерный массив");

            Auto[] cars1 = new Auto[2] {
               new Auto("car0", 400, 300000),
               new Auto("car1", 430, 333320),
            };

            for (int i = 0; i < 2; i++) 
                cars1[i].display();


            Console.WriteLine("\nДвумерный массив");

            Auto[][] cars2 = new Auto[2][];

            for (int i = 0; i < 2; i++)
                cars2[i] = new Auto[2];

            for (int i = 0; i < 2; i++) 
                for (int j = 0; j < 2; j++)
                    cars2[i][j] = new Auto("car" + i.ToString() + j.ToString(), 7*(i+j+1), 20*(i+j+1));

            for (int i = 0; i < 2; i++) 
                for (int j = 0; j < 2; j++)
                    cars2[i][j].display();
        }

    }
}
