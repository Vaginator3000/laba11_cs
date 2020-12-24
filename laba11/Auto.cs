using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Auto
    {
        String brand; //марка
        int power; //цвет
        int cost;     //стоимость
        public Auto()
        {
            brand = "";
            power = 0;
            cost = 0;
        }

        public Auto(String brand)
        {
            this.brand = brand;
            power = 0;
            cost = 0;
        }

        public Auto(String brand, int power, int cost)
        {
            this.brand = brand;
            this.cost = cost;
            this.power = power;
        }

        public void display()
        {
            Console.WriteLine($"{brand}, {power} - {cost}p");
        }

        public void read()
        {
            Console.WriteLine("Марка: ");
            brand = Console.ReadLine();
            Console.WriteLine("Мощность: ");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость: ");
            cost = Convert.ToInt32(Console.ReadLine());
        }

    }
}
