using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    internal class task16
    {
        static void Main(string[] args)
        {
            //Даны длины сторон прямоугольного параллелепипеда.Найти его объем и площадь боковой поверхности.

            Console.Write("Введите длину: ");
            double lenght = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину: ");
            double widht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double heigth = Convert.ToDouble(Console.ReadLine());

            double volume = lenght * widht * heigth;
            Console.WriteLine($"Объем параллелипипеда равен : {volume} см3");

            double square = lenght * heigth;
            Console.WriteLine($"Объем параллелипипеда равен : {square} см2");


        }
    }
}
