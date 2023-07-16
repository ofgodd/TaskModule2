using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    internal class task25
    {
        static void Main(string[] args)
        {
            //Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и V2 км / час.
            //Определить, через какое время автомобили встретятся, если расстояние между ними было S км.

            Console.Write("Задайте скорость первого автомобиля: ");
            double firstCarSpeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Задайте скорость первого автомобиля: ");
            double secondCarSpeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Задайте расстояние между автомобилями: ");
            double distanceBetweenCar = Convert.ToDouble(Console.ReadLine());

            double timeEncounter = distanceBetweenCar / (firstCarSpeed + secondCarSpeed) * 60;
            Console.WriteLine("Время встречи автомобилей :" + timeEncounter);

        }
    }
}
